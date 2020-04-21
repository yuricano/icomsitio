using System;
using System.Data;
using System.Data.SqlClient;

namespace iCom_BusinessData
{
    public class Log : conexionGeneral
    {
        public Log()
        {
        }

        //
        public DataTable Insertar(iCom_BusinessEntity.Log oBE)
        {
            try
            {
                DataTable dtResultado = new DataTable();

                oComando.CommandText = "dbo.spInsLog";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();
                 
                oParametro = new System.Data.SqlClient.SqlParameter("@idusuario", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idusuario;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@modulo", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.modulo;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@descripcion", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.descripcion;
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