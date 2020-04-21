using System;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Globalization;
using System.Net;

public partial class _Solicitud : System.Web.UI.Page
{
    static DataTable dtDatos = new DataTable();
    static DataTable dtFiltro = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Catalogos
            Carga_Catalogos();
        }
    }

    protected void ddlPais_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlEstado.Items.Clear();
        ddlCiudad.Items.Clear();

        try
        {
            dtFiltro = Filtros.Estado(0, ddlPais.SelectedIndex);
            if (dtFiltro.Rows.Count > 0)
            {
                ddlEstado.Items.Add(new ListItem("Selecciona"));
                foreach (DataRow row in dtFiltro.Rows)
                {
                    ddlEstado.Items.Add(new ListItem(row[2].ToString()));
                }
            }

            ddlEstado.Focus();
        }
        catch (Exception ex)
        {
            ResgitraLog(ex.Message);
            return;
        }
    }

    protected void ddlEstado_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlCiudad.Items.Clear();

        try
        {
            dtFiltro = Filtros.Ciudad(0, ddlEstado.SelectedIndex);
            if (dtFiltro.Rows.Count > 0)
            {
                ddlCiudad.Items.Add(new ListItem("Selecciona"));
                foreach (DataRow row in dtFiltro.Rows)
                {
                    ddlCiudad.Items.Add(new ListItem(row[2].ToString()));
                }
            }

            ddlCiudad.Focus();
        }
        catch (Exception ex)
        {
            ResgitraLog(ex.Message);
            return;
        }
    }

    // Guardar
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        // Validar
        if (!Valida())
        {
            return;
        }

        // Valida Archivos
        if (Request.Files[0].ContentLength == 0)
        {
            ResgitraLog("Para poder realizar tu inscripción es necesario que nos envíes tu documentación.");
            return;
        }

        foreach (HttpPostedFile postedFile in FileUpload.PostedFiles)
        {
            // Tamaño
            string fileName = Path.GetFileName(postedFile.FileName);
            int iFileSize = postedFile.ContentLength;

            if (iFileSize > 1048576)  // 1MB
            {
                ResgitraLog("El archivo " + postedFile.FileName + " es demasiado grande. Max 1 MB por archivo");
                return;
            }

            Regex reg = new Regex(@"^.*\.(pdf|PDF)$");
            if (!reg.IsMatch(fileName))
            {
                ResgitraLog("Solo puedes eniviar archivos con formato PDF");
                return;
            }
        }

        // Creo el nuevo usuario
        int idusuario = 0;

        iCom_BusinessLogic.Usuario oBLUsuario = new iCom_BusinessLogic.Usuario();

        // Obtengo el id
        try
        {
            dtDatos = oBLUsuario.IdUsuario();

            if (dtDatos.Rows.Count > 0)
            {
                idusuario = int.Parse(dtDatos.Rows[0]["idusuario"].ToString());
            }
            else
            {
                ResgitraLog("No se obtuvo el ID");
                return;
            }

            // Carpeta por alumno
            string dirAlumno = Server.MapPath("~/Cargas/") + idusuario.ToString();

            if (!Directory.Exists(dirAlumno))
            {
                Directory.CreateDirectory(dirAlumno);
            }

            foreach (HttpPostedFile postedFile in FileUpload.PostedFiles)
            {
                // Tamaño
                string fileName = Path.GetFileName(postedFile.FileName);

                fileName = idusuario.ToString() + "-" + fileName;
                postedFile.SaveAs(dirAlumno + "//" + fileName);
            }

            // Alta de Usuario
            iCom_BusinessEntity.Usuario oBE = new iCom_BusinessEntity.Usuario();
            oBE.usuario = "al" + DateTime.Now.Year.ToString() + idusuario.ToString();
            oBE.contrasena = "123456";
            oBE.idusuariotipo = 4;

            dtDatos = oBLUsuario.Insertar(oBE);

            // Datos generales
            iCom_BusinessEntity.UsuarioDatosGenerales oBEDG = new iCom_BusinessEntity.UsuarioDatosGenerales();

            oBEDG.idusuario = idusuario;
            oBEDG.nombre = txtNombre.Text;
            oBEDG.appaterno = txtApPaterno.Text;
            oBEDG.apmaterno = txtApMaterno.Text;
            oBEDG.idmodeloeducativo = 1;
            oBEDG.idperiodoescolar = ddlPeriodo.SelectedIndex;
            oBEDG.matricula = "al" + DateTime.Now.Year.ToString() + idusuario.ToString();
            oBEDG.idcarrera = ddlCarrera.SelectedIndex;

            // Revisar
            string sFecha = txtAnio.Text + "-" + ddlMes.SelectedItem.ToString() + "-" + ddlDia.SelectedItem.ToString();
            DateTime fecha = Convert.ToDateTime(sFecha + " 00:00:00.000", CultureInfo.InvariantCulture);
            oBEDG.fechanacimiento = fecha;
            
            //oBEDG.fechanacimiento = DateTime.Parse("01-01-2019");
            ResgitraLog(oBEDG.fechanacimiento.ToString());

            oBEDG.nacionalidad = txtNacionalidad.Text;
            oBEDG.telefono = txtTelContacto.Text;
            oBEDG.email = txtCorreo.Text;
            oBEDG.idsexo = int.Parse(rblSexo.SelectedValue.ToString());
            oBEDG.idestadocivil = int.Parse(rblEdoCivil.SelectedValue.ToString());
            oBEDG.curp = txtCURP.Text;
            oBEDG.escuelaprocedencia = txtEscuelaProcedencia.Text;

            iCom_BusinessLogic.UsuarioDatosGenerales oBLUG = new iCom_BusinessLogic.UsuarioDatosGenerales();
            dtDatos = oBLUG.Insertar(oBEDG);

            // Datos Direccion
            iCom_BusinessEntity.UsuarioDireccion oBEDir = new iCom_BusinessEntity.UsuarioDireccion();

            oBEDir.idusuario = idusuario;
            oBEDir.idusuariopadres = 0;
            oBEDir.calle = txtCalle.Text;
            oBEDir.numeroexterior = txtNumero.Text;
            oBEDir.numerointerior = txtNumeroInt.Text;
            oBEDir.colonia = txtColonia.Text;
            oBEDir.codigopostal = txtCP.Text;
            oBEDir.idciudad = ddlCiudad.SelectedIndex;
            oBEDir.idestado = ddlEstado.SelectedIndex;
            oBEDir.idpais = ddlPais.SelectedIndex;

            iCom_BusinessLogic.UsuarioDireccion oBLDir = new iCom_BusinessLogic.UsuarioDireccion();
            dtDatos = oBLDir.Insertar(oBEDir);

            // Laboral
            iCom_BusinessEntity.UsuarioLaboral oBEL = new iCom_BusinessEntity.UsuarioLaboral();

            oBEL.idusuario = idusuario;
            oBEL.labora = false;
            oBEL.nombreempresa = string.Empty;
            oBEL.puesto = string.Empty;
            oBEL.dias = string.Empty;
            //oBEL.horariodesde = null;
            //oBEL.horariohasta = null;
            oBEL.telefono = string.Empty;
            oBEL.descripciondoncente = string.Empty;

            iCom_BusinessLogic.UsuarioLaboral oBLL = new iCom_BusinessLogic.UsuarioLaboral();
            dtDatos = oBLL.Insertar(oBEL);

            string sBody = "Hola,\n" +
                "Tu proceso de inscripción se ha iniciado exitosamente.\n" +
                "Saludos!\n" +
                "usuario: " + oBE.usuario + "\n" + "contraseña: " + oBE.contrasena;

            enviarMail(sBody);

            ResgitraLog("LISTO! Tu proceso de inscripción se ha iniciado exitosamente. <br> " +
                "Recibirás un correo electrónico con los pasos a seguir para completar tu matrícula.");

            btnGUardar.Enabled = false;
        }
        catch (Exception ex)
        {
            ResgitraLog(ex.Message);
            return;
        }
    }

    protected void enviarMail(String sBody)
    {
        //var fromAddress = new MailAddress("tucorreode@gmail.com", "From Name");
        //var toAddress = new MailAddress("to@example.com", "To Name");
        //const string fromPassword = "fromPassword";
        //const string subject = "Subject";
        //const string body = "Body";

        //var smtp = new SmtpClient
        //{
        //    Host = "smtp.gmail.com",
        //    Port = 587,
        //    EnableSsl = true,
        //    DeliveryMethod = SmtpDeliveryMethod.Network,
        //    UseDefaultCredentials = false,
        //    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
        //};
        //using (var message = new MailMessage(fromAddress, toAddress)
        //{
        //    Subject = subject,
        //    Body = body
        //})
        //{
        //    smtp.Send(message);
        //}

        // Otro
        //        < configuration >
        //  < host > smtp.gmail.com </ host >
        //  < port > 587 </ port >
        //  < user > tucuenta@gmail.com </ user >
   
        //     < password > contraseñagmail </ password >
   
        //     < enableSsl > true </ enableSsl >
        //   </ configuration >

        //  using System;
        //        using EmailService;
        //        using System.Net.Mail;
        //        using System.Net.Mime;

        //namespace EmailServiceCliente
        //{
        //    class Program
        //    {
        //        static void Main(string[] args)
        //        {
        //            try
        //            {
        //                GestorCorreo gestor = new GestorCorreo();

        //                //Correo con archivos adjuntos
        //                MailMessage correo = new MailMessage("tucuenta@gmail.com",
        //                                                     "benjamin@aspnetcoremaster.com",
        //                                                     "Archivo de configuracíon",
        //                                                     "Por favor verificar adjunto.");

        //                string ruta = "Configuracion.xml";
        //                Attachment adjunto = new Attachment(ruta, MediaTypeNames.Application.Xml);
        //                correo.Attachments.Add(adjunto);
        //                gestor.EnviarCorreo(correo);

        //                // Correo con HTML
        //                gestor.EnviarCorreo("tucuenta@gmail.com",
        //                                    "Prueba",
        //                                    "Mensaje en texto plano");
        //                // Correo de texto  
        //                gestor.EnviarCorreo("tucuenta@gmail.com",
        //                                    "Prueba",
        //                                    "<h1>Mensaje en HTML<h1><p>Contenido</p>",
        //                                    true);
        //            }
        //            catch (System.Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //            }
        //        }
        //    }
        //}

        try
        {
            //System.Net.Mail.MailMessage correo = new System.Net.Mail.MailMessage();
            //correo.From = new System.Net.Mail.MailAddress("yuri.cano.dev@gmail.com");
            //correo.To.Add("yuri.cano.dev@gmail.com");
            //correo.Subject = "Registro iCOM";
            //correo.Body = sBody;
            //correo.IsBodyHtml = false;
            //correo.Priority = System.Net.Mail.MailPriority.Normal;

            //System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
            //smtp.Host = "smtp.gmail.com";
            //smtp.Credentials = new System.Net.NetworkCredential("yuri.cano.dev@gmail.com", "YuriCano.9");
            //smtp.EnableSsl = true;
            //smtp.Send(correo);



            //Secure WebMail Interface: https://mail5006.site4now.net
            //MX Record Address: igw5002.site4now.net
            //SMTP Host: mail.icom.education
            //SMTP Port: 25 or 8889(if your isp blocks port 25)
            //SSL Ports:   SMTP: 465, POP3: 995, IMAP: 993


            var client = new SmtpClient("mail.icom.education", 25)
            {
                Credentials = new NetworkCredential("admisiones@icom.education", "iCom2018.!"),
                EnableSsl = true
            };
            client.Send("yuri.ivann.cano@gmail.ctom", "yuri.cano.dev@gmail.com", "test", "testbody");
            Console.WriteLine("Sent");
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            ResgitraLog(ex.Message);
            return;
        }
    } 

    #region Datos

    // Catalogos
    protected void Carga_Catalogos()
    {
        try
        {
            // Día
            ddlDia.Items.Add(new ListItem("Día"));

            for (int i = 1; i <= 31; i++)
            {
                ddlDia.Items.Add(new ListItem(i.ToString()));
            }

            // Mes
            ddlMes.Items.Add(new ListItem("Mes"));

            for (int i = 1; i <= 12; i++)
            {
                ddlMes.Items.Add(new ListItem(i.ToString()));
            }

            // Carrera
            dtDatos = Filtros.Carrera(0);
            if (dtDatos.Rows.Count > 0)
            {
                ddlCarrera.Items.Add(new ListItem("Selecciona"));
                foreach (DataRow row in dtDatos.Rows)
                {
                    ddlCarrera.Items.Add(new ListItem(row[1].ToString()));
                }
            }

            // Periodo Escolar
            dtDatos = Filtros.PeriodoEscolar(0);
            if (dtDatos.Rows.Count > 0)
            {
                ddlPeriodo.Items.Add(new ListItem("Selecciona"));
                foreach (DataRow row in dtDatos.Rows)
                {
                    ddlPeriodo.Items.Add(new ListItem(row[3].ToString()));
                }
            }

            // Pais
            dtDatos = Filtros.Pais(0);
            if (dtDatos.Rows.Count > 0)
            {
                ddlPais.Items.Add(new ListItem("Selecciona"));
                foreach (DataRow row in dtDatos.Rows)
                {
                    ddlPais.Items.Add(new ListItem(row[1].ToString()));
                }
            }
        }
        catch (Exception ex)
        {
            ResgitraLog(ex.Message);
            return;
        }
    }

    protected bool Valida()
    {
        bool bSelccion = false;

        // Validacion
        if (txtNombre.Text.Trim() == "")
        {
            txtNombre.Focus();
            ResgitraLog("Nombre requerido");
            return false;
        }

        if (txtApPaterno.Text.Trim() == "")
        {
            txtApPaterno.Focus();
            ResgitraLog("Apellido Paterno requerido");
            return false;
        }

        if (txtApMaterno.Text.Trim() == "")
        {
            txtApMaterno.Focus();
            ResgitraLog("Apellido Mateno requerido");
            return false;
        }

        if (ddlDia.SelectedIndex == 0)
        {
            ddlDia.Focus();
            ResgitraLog("Día requerido");
            return false;
        }

        if (ddlMes.SelectedIndex == 0)
        {
            ddlMes.Focus();
            ResgitraLog("Mes requerido");
            return false;
        }

        if (txtAnio.Text.Trim() == "")
        {
            txtAnio.Focus();
            ResgitraLog("Año requerido");
            return false;
        }

        if (txtNacionalidad.Text.Trim() == "")
        {
            txtNacionalidad.Focus();
            ResgitraLog("Nacionalidad requerido");
            return false;
        }

        if (txtCURP.Text.Trim() == "")
        {
            txtCURP.Focus();
            ResgitraLog("CURP/ID Nacionalidad requerido");
            return false;
        }

        if (txtCalle.Text.Trim() == "")
        {
            txtCalle.Focus();
            ResgitraLog("Calle requerido");
            return false;
        }

        if (txtNumero.Text.Trim() == "")
        {
            txtNumero.Focus();
            ResgitraLog("Número exterior requerido");
            return false;
        }

        if (txtColonia.Text.Trim() == "")
        {
            txtColonia.Focus();
            ResgitraLog("Colonia requerido");
            return false;
        }

        if (ddlPais.SelectedIndex == 0)
        {
            ddlPais.Focus();
            ResgitraLog("País requerido");
            return false;
        }

        if (ddlEstado.SelectedIndex == 0)
        {
            ddlEstado.Focus();
            ResgitraLog("Estado requerido");
            return false;
        }

        if (ddlCiudad.SelectedIndex == 0)
        {
            ddlCiudad.Focus();
            ResgitraLog("Ciudad requerido");
            return false;
        }

        if (txtCP.Text.Trim() == "")
        {
            txtCP.Focus();
            ResgitraLog("Código Postal requerido");
            return false;
        }

        if (txtTelContacto.Text.Trim() == "")
        {
            txtTelContacto.Focus();
            ResgitraLog("Teléfono de contacto requerido");
            return false;
        }

        if (txtCorreo.Text.Trim() == "")
        {
            txtCorreo.Focus();
            ResgitraLog("Correo electrónico requerido");
            return false;
        }

        if (ddlPeriodo.SelectedIndex == 0)
        {
            ddlPeriodo.Focus();
            ResgitraLog("Periodo requerido");
            return false;
        }

        if (ddlCarrera.SelectedIndex == 0)
        {
            ddlCarrera.Focus();
            ResgitraLog("Oferta educativa requerido");
            return false;
        }

        if (txtEscuelaProcedencia.Text.Trim() == "")
        {
            txtEscuelaProcedencia.Focus();
            ResgitraLog("Escuela de procedencia requerido");
            return false;
        }

        foreach (ListItem lisit in chkDocumentos.Items)
        {
            if (lisit.Selected)
            {
                bSelccion = true;
                break;
            }
        }

        if (!bSelccion)
        {
            chkDocumentos.Focus();
            ResgitraLog("Debes de seleccionar los documentos de inscripción que nos enviarás.");
            return false;
        }

        return true;
    }
    #endregion

    #region Log
    protected void ResgitraLog(string sMensaje)
    {
        Log._Log(Convert.ToInt32(Session["id"]), "_Solicitud", sMensaje);
        lblMensaje.Text = "<br />" + sMensaje;
        mp1.Show();
    }
    #endregion
}
