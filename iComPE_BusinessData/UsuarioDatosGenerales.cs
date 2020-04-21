using System;
using System.Data;
using System.Data.SqlClient;

namespace iCom_BusinessData
{
    public class UsuarioDatosGenerales : conexionGeneral
    {
        public UsuarioDatosGenerales()
        {
        }

        //
        public DataTable Consultar(iCom_BusinessEntity.UsuarioDatosGenerales oBE)
        {
            try
            {
                DataTable dtResultado = new DataTable();

                oComando.CommandText = "dbo.spGetUsuarioDatosGenerales";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();
                oParametro = new System.Data.SqlClient.SqlParameter("@idusuario", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idusuario;
                oComando.Parameters.Add(oParametro);

                if (this.Conectar())
                {
                    SqlDataAdapter daResultado = new SqlDataAdapter(oComando);
                    daResultado.Fill(dtResultado);
                    Desconectar();
                }
                return dtResultado;
            }
            catch (Exception ex)
            {
                Desconectar();
                throw ex;
            }
        }

        //
        public DataTable Insertar(iCom_BusinessEntity.UsuarioDatosGenerales oBE)
        {
            try
            {
                DataTable dtResultado = new DataTable();

                oComando.CommandText = "dbo.spInsUsuarioDatosGenerales";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();
                oParametro = new System.Data.SqlClient.SqlParameter("@idusuario", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idusuario;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.nombre;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@appaterno", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.appaterno;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@apmaterno", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.apmaterno;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@idmodeloeducativo", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idmodeloeducativo;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@idperiodoescolar", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idperiodoescolar;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@matricula", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.matricula;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@idcarrera", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idcarrera;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@fechanacimiento", System.Data.SqlDbType.Date);
                oParametro.Value = oBE.fechanacimiento;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@nacionalidad", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.nacionalidad;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.telefono;
                oComando.Parameters.Add(oParametro);
;

                oParametro = new System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.email;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@idsexo", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idsexo;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@idestadocivil", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idestadocivil;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@curp", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.curp;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@escuelaprocedencia", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.escuelaprocedencia;
                oComando.Parameters.Add(oParametro);

                if (this.Conectar())
                {
                    SqlDataAdapter daResultado = new SqlDataAdapter(oComando);
                    daResultado.Fill(dtResultado);
                    Desconectar();
                }
                return dtResultado;
            }
            catch (Exception ex)
            {
                Desconectar();
                throw ex;
            }
        }

        //
        public DataTable Actualizar(iCom_BusinessEntity.UsuarioDatosGenerales oBE)
        {
            try
            {
                DataTable dtResultado = new DataTable();

                oComando.CommandText = "dbo.spUpdUsuario";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();
                oParametro = new System.Data.SqlClient.SqlParameter("@idusuario", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idusuario;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@usuariotipo", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idusuario;
                oComando.Parameters.Add(oParametro);

                if (this.Conectar())
                {
                    SqlDataAdapter daResultado = new SqlDataAdapter(oComando);
                    daResultado.Fill(dtResultado);
                    Desconectar();
                }
                return dtResultado;
            }
            catch (Exception ex)
            {
                Desconectar();
                throw ex;
            }
        }
    }
}
