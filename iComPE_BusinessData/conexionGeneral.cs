using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace iCom_BusinessData
{
    public class conexionGeneral
    {
        protected string sCon;
        protected SqlConnection oConexion;
        protected SqlDataReader oLector;
        protected SqlCommand oComando;
        protected SqlParameter oParametro;


        public conexionGeneral()
        {
            try
            {
                sCon = System.Configuration.ConfigurationManager.ConnectionStrings["sConn"].ToString();                
                oConexion = new SqlConnection(sCon);
                oComando = new SqlCommand("", oConexion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual bool Conectar()
        {
            bool bTmp = false;

            try
            {
                bTmp = true;
                oConexion.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return bTmp;
        }

        public virtual bool Desconectar()
        {
            try
            {
                if (oConexion.State == System.Data.ConnectionState.Open)
                {
                    oConexion.Close();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
