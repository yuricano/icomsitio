using System;
using System.Data;
using System.Data.SqlClient;

namespace iCom_BusinessData
{
    public class UsuarioDireccion : conexionGeneral
    {
        public UsuarioDireccion()
        {
        }

        //
        public DataTable Consultar(iCom_BusinessEntity.UsuarioDireccion oBE)
        {
            try
            {
                DataTable dtResultado = new DataTable();

                oComando.CommandText = "dbo.spGetUsuarioDireccion";
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
        public DataTable Insertar(iCom_BusinessEntity.UsuarioDireccion oBE)
        {
            try
            {
                DataTable dtResultado = new DataTable();

                oComando.CommandText = "dbo.spInsUsuarioDireccion";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();

                oParametro = new System.Data.SqlClient.SqlParameter("@idusuario", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idusuario;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@idusuariopadres", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idusuariopadres;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@calle", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.calle;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@numeroexterior", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.numeroexterior;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@numerointerior", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.numerointerior;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@colonia", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.colonia;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@codigopostal", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.codigopostal;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@idciudad", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idciudad;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@idestado", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idestado;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@idpais", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idpais;
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


        public DataTable Actualizar(iCom_BusinessEntity.UsuarioDireccion oBE)
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
