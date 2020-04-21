using System;
using System.Data;
using System.Data.SqlClient;

namespace iCom_BusinessData
{
    public class Pais : conexionGeneral
    {
        public Pais()
        {
        }

        //
        public DataTable Consultar(iCom_BusinessEntity.Pais oBE)
        {
            try
            {
                DataTable dtResultado = new DataTable();

                oComando.CommandText = "dbo.spGetPais";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;
                oComando.Parameters.Clear();

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

        public DataTable Insertar(iCom_BusinessEntity.Pais oBE)
        {
            try
            {
                DataTable dtResultado = new DataTable();

                oComando.CommandText = "dbo.spInsPais";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();
                oParametro = new System.Data.SqlClient.SqlParameter("@pais", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.pais;
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
