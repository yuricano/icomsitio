using System;
using System.Data;
using iCom_BusinessData;

namespace iCom_BusinessLogic
{
    public class Estado : conexionGeneral
    {
        public Estado()
        {
        }

        //
        public DataTable Consultar(iCom_BusinessEntity.Estado oBE)
        {
            try
            {
                iCom_BusinessData.Estado oBD = new iCom_BusinessData.Estado();
                return oBD.Consultar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
