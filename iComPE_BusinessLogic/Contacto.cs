using System;
using System.Data;
using iCom_BusinessData;

namespace iCom_BusinessLogic
{
    public class Contacto: conexionGeneral
    {
        public Contacto()
        {
        }

        //
        public DataTable Consultar(iCom_BusinessEntity.Contacto oBE)
        {
            try
            {
                iCom_BusinessData.Contacto oBD = new iCom_BusinessData.Contacto();
                return oBD.Consultar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //
        public DataTable Insertar(iCom_BusinessEntity.Contacto oBE)
        {
            try
            {
                iCom_BusinessData.Contacto oBD = new iCom_BusinessData.Contacto();
                return oBD.Insertar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //
        public DataTable Actualizar(iCom_BusinessEntity.Contacto oBE)
        {
            try
            {
                iCom_BusinessData.Contacto oBD = new iCom_BusinessData.Contacto();
                return oBD.Actualizar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
