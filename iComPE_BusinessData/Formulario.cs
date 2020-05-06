using System;
using System.Data;
using System.Data.SqlClient;

namespace iCom_BusinessData
{
    public class Formulario : conexionGeneral
    {
        public Formulario()
        {
        }

        //
        public DataTable Consultar(iCom_BusinessEntity.Formulario oBE)
        {
            try
            {
                DataTable dtResultado = new DataTable();

                oComando.CommandText = "dbo.spGetFormulario";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;
                oComando.Parameters.Clear();

                oParametro = new System.Data.SqlClient.SqlParameter("@contactado", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.contactado;
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

        public DataTable Insertar(iCom_BusinessEntity.Formulario oBE)
        {
            try
            {
                DataTable dtResultado = new DataTable();

                oComando.CommandText = "dbo.spInsFormulario";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();

                oParametro = new System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.nombre;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@apellido", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.apellido;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@correo", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.correo;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@telefono", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.nombre;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@mensaje", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.mensaje;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@pais", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.nombre;
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
