using System;
using System.Data;
using iCom_BusinessData;

namespace iCom_BusinessLogic
{
    public class Login : conexionGeneral
    {
        public Login()
        {
        }

        //
        public DataTable Consultar(iCom_BusinessEntity.Login oBE)
        {
            try
            {
                iCom_BusinessData.Login oBD = new iCom_BusinessData.Login();
                return oBD.Consultar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //
        //public DataTable Actualiza(iCom_BusinessEntity.RuteoManual oBE)
        //{
        //    try
        //    {
        //        iCom_BusinessData.RuteoManual oBD = new iCom_BusinessData.RuteoManual();
        //        return oBD.Actualiza(oBE);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
