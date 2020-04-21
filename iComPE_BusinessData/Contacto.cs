using System;
using System.Data;
using System.Data.SqlClient;

namespace iCom_BusinessData
{
    public class Contacto : conexionGeneral
    {
        public Contacto()
        {
        }

        //
        public DataTable Consultar(iCom_BusinessEntity.Contacto oBE)
        {
            try
            {
                DataTable dtResultado = new DataTable();

                oComando.CommandText = "dbo.spGetUsuario";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();
                oParametro = new System.Data.SqlClient.SqlParameter("@idusuario", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idcarrera;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@usuariotipo", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.mensaje;
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
        public DataTable Insertar(iCom_BusinessEntity.Contacto oBE)
        {
            try
            {
                DataTable dtResultado = new DataTable();

                oComando.CommandText = "dbo.spInsUsuario";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();
                oParametro = new System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idcarrera;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@contrasena", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.nombre;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@idusuariotipo", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idcarrera;
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


        public DataTable Actualizar(iCom_BusinessEntity.Contacto oBE)
        {
            try
            {
                DataTable dtResultado = new DataTable();

                oComando.CommandText = "dbo.spUpdUsuario";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();
                oParametro = new System.Data.SqlClient.SqlParameter("@idusuario", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idcarrera;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@usuariotipo", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idcarrera;
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
