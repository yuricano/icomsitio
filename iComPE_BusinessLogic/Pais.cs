using System;
using System.Data;
using iCom_BusinessData;

namespace iCom_BusinessLogic
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
                iCom_BusinessData.Pais oBD = new iCom_BusinessData.Pais();
                return oBD.Consultar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //
        public DataTable Insertar(iCom_BusinessEntity.Pais oBE)
        {
            try
            {
                iCom_BusinessData.Pais oBD = new iCom_BusinessData.Pais();
                return oBD.Insertar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
