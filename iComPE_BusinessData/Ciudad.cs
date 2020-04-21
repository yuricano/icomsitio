using System;
using System.Data;
using System.Data.SqlClient;

namespace iCom_BusinessData
{
    public class Ciudad : conexionGeneral
    {
        public Ciudad()
        {
        }

        //
        public DataTable Consultar(iCom_BusinessEntity.Ciudad oBE)
        {
            try
            {
                DataTable dtResultado = new DataTable();

                oComando.CommandText = "dbo.spGetCiudad";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;
                oComando.Parameters.Clear();

                oParametro = new System.Data.SqlClient.SqlParameter("@idCiudad", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idciudad;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@idestado", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idestado;
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
