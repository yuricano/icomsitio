using System;
using System.Data;
using iCom_BusinessData;

namespace iCom_BusinessLogic
{
    public class Formulario : conexionGeneral
    {
        public Formulario()
        {
        }

        //
        public DataTable Consultar(iCom_BusinessEntity.Formulario oBE)
        {
            try
            {
                iCom_BusinessData.Formulario oBD = new iCom_BusinessData.Formulario();
                return oBD.Consultar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //
        public DataTable Insertar(iCom_BusinessEntity.Formulario oBE)
        {
            try
            {
                iCom_BusinessData.Formulario oBD = new iCom_BusinessData.Formulario();
                return oBD.Insertar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
