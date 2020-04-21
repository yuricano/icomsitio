using System;
using System.Data;
using System.Data.SqlClient;

namespace iCom_BusinessData
{
    public class PeriodoEscolar : conexionGeneral
    {
        public PeriodoEscolar()
        {
        }

        //
        public DataTable Consultar(iCom_BusinessEntity.PeriodoEscolar oBE)
        {
            try
            {
                DataTable dtResultado = new DataTable();

                oComando.CommandText = "dbo.spGetPeriodoEscolar";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();
                oParametro = new System.Data.SqlClient.SqlParameter("@idperiodoescolar", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idperiodoescolar;
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
