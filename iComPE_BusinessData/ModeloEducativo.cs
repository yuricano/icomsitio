using System;
using System.Data;
using System.Data.SqlClient;

namespace iCom_BusinessData
{
    public class ModeloEducativo : conexionGeneral
    {
        public ModeloEducativo()
        {
        }

        //
        public DataTable Consultar(iCom_BusinessEntity.ModeloEducativo oBE)
        {
            try
            {
                DataTable dtResultado = new DataTable();

                oComando.CommandText = "dbo.spGetModeloEducativo";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();
                oParametro = new System.Data.SqlClient.SqlParameter("@idmodeloeducativo", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idmodeloeducativo;
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
