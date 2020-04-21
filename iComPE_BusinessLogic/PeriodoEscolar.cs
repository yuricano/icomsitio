using System;
using System.Data;
using iCom_BusinessData;

namespace iCom_BusinessLogic
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
                iCom_BusinessData.PeriodoEscolar oBD = new iCom_BusinessData.PeriodoEscolar();
                return oBD.Consultar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
