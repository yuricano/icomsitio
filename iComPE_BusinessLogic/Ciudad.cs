using System;
using System.Data;
using iCom_BusinessData;

namespace iCom_BusinessLogic
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
                iCom_BusinessData.Ciudad oBD = new iCom_BusinessData.Ciudad();
                return oBD.Consultar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
