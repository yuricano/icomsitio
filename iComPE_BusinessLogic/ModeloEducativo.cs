using System;
using System.Data;
using iCom_BusinessData;

namespace iCom_BusinessLogic
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
                iCom_BusinessData.ModeloEducativo oBD = new iCom_BusinessData.ModeloEducativo();
                return oBD.Consultar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
