using System;
using System.Data;
using System.Data.SqlClient;

namespace iCom_BusinessData
{
    public class Login : conexionGeneral
    {
        public Login()
        {
        }

        //
        public DataTable Consultar(iCom_BusinessEntity.Login oBE)
        {
            try
            {
                DataTable dtResultado = new DataTable();

                oComando.CommandText = "dbo.spLogin";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();
                oParametro = new System.Data.SqlClient.SqlParameter("@Usuario", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.Usuario;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@Contrasena", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.Contrasena;
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
