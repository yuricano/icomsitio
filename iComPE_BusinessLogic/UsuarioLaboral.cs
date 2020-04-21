using System;
using System.Data;
using iCom_BusinessData;

namespace iCom_BusinessLogic
{
    public class UsuarioLaboral : conexionGeneral
    {
        public UsuarioLaboral()
        {
        }

        //
        public DataTable Consultar(iCom_BusinessEntity.UsuarioLaboral oBE)
        {
            try
            {
                iCom_BusinessData.UsuarioLaboral oBD = new iCom_BusinessData.UsuarioLaboral();
                return oBD.Consultar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //
        public DataTable Insertar(iCom_BusinessEntity.UsuarioLaboral oBE)
        {
            try
            {
                iCom_BusinessData.UsuarioLaboral oBD = new iCom_BusinessData.UsuarioLaboral();
                return oBD.Insertar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //
        public DataTable Actualizar(iCom_BusinessEntity.UsuarioLaboral oBE)
        {
            try
            {
                iCom_BusinessData.UsuarioLaboral oBD = new iCom_BusinessData.UsuarioLaboral();
                return oBD.Actualizar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
