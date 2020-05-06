using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using iCom_Generales;

public partial class Admin : System.Web.UI.MasterPage
{
    static bool bGuarda = true;
    static DataTable dtDatos;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    #region contacto
    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        string sBody = "Gracias por contactarnos " + txtNombre.Text.Trim() + "\n" +
            "Un asesor académico se pondrá en contacto contigo.\n" +
            "Saludos!\n";

        if (!Valida())
        {
            return;
        }

        // Guardo contacto
        iCom_BusinessLogic.Formulario oBL = new iCom_BusinessLogic.Formulario();
        iCom_BusinessEntity.Formulario oBE = new iCom_BusinessEntity.Formulario();

        oBE.nombre = txtNombre.Text.Trim();
        oBE.apellido = txtApellido.Text.Trim();
        oBE.correo = txtCorreo.Text.Trim();
        oBE.telefono = txtTelefono.Text.Trim();
        oBE.mensaje = txtMensaje.Text.Trim();
        
        dtDatos = oBL.Insertar(oBE);

        ResgitraLog("Guarda Formulario " + oBE.nombre + " - " + oBE.telefono + " - " + oBE.correo + " - " + oBE.mensaje);

        enviarMail(sBody, txtCorreo.Text.Trim());

        // Ya se envio.
        bGuarda = false;
        btnEnviar.Enabled = false;
    }

    protected void enviarMail(String sBody, string sMailAlumno)
    {
        try
        {
            var client = new SmtpClient("mail.icom.education", 25)
            {
                Credentials = new NetworkCredential("admisiones@icom.education", "iCom2018.!"),
                EnableSsl = false
            };
            client.Send("admisiones@icom.education", sMailAlumno, "iCom Admisiones", sBody);
            ResgitraLog("Enviando: " + sBody + " - " + sMailAlumno);
        }
        catch (Exception ex)
        {
            ResgitraLog(ex.Message);
            return;
        }
    }
    #endregion

    #region datos
    protected bool Valida()
    {
        // Validacion
        if (bGuarda == false)
        {
            ResgitraLog("El formulario ya ha sido enviado.");
            return false;
        }

        if (txtNombre.Text.Trim() == "")
        {
            txtNombre.Focus();
            ResgitraLog("Nombre requerido");
            return false;
        }

        if (txtApellido.Text.Trim() == "")
        {
            txtApellido.Focus();
            ResgitraLog("Apellido requerido");
            return false;
        }

        if (txtCorreo.Text.Trim() == "")
        {
            txtCorreo.Focus();
            ResgitraLog("Correo electrónico requerido");
            return false;
        }
        if (txtTelefono.Text.Trim() == "")
        {
            txtTelefono.Focus();
            ResgitraLog("Teléfono de contacto requerido");
            return false;
        }
        return true;
    }
    #endregion

    #region Log
    protected void ResgitraLog(string sMensaje)
    {
        
        Log._Log(-1, "_Contacto", sMensaje);
        //lblMensaje.Text = "<br />" + sMensaje;
        //mp1.Show();
    }
    #endregion
}

