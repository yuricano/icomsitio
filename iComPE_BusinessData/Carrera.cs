using System;
using System.Data;
using System.Data.SqlClient;

namespace iCom_BusinessData
{
    public class Carrera : conexionGeneral
    {
        public Carrera()
        {
        }

        //
        public DataTable Consultar(iCom_BusinessEntity.Carrera oBE)
        {
            try
            {
                DataTable dtResultado = new DataTable();

                oComando.CommandText = "dbo.spGetCarrera";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();
                oParametro = new System.Data.SqlClient.SqlParameter("@idcarrera", System.Data.SqlDbType.Int);
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
