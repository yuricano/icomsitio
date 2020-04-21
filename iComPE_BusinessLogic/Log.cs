using System;
using System.Data;
using iCom_BusinessData;

namespace iCom_BusinessLogic
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
                iCom_BusinessData.Log oBD = new iCom_BusinessData.Log();
                return oBD.Insertar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
