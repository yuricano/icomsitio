using System;
using System.Data;
using iCom_BusinessData;

namespace iCom_BusinessLogic
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
                iCom_BusinessData.Carrera oBD = new iCom_BusinessData.Carrera();
                return oBD.Consultar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
