using System;
using System.Data;
using iCom_BusinessData;

namespace iCom_BusinessLogic
{
    public class UsuarioDireccion : conexionGeneral
    {
        public UsuarioDireccion()
        {
        }

        //
        public DataTable Consultar(iCom_BusinessEntity.UsuarioDireccion oBE)
        {
            try
            {
                iCom_BusinessData.UsuarioDireccion oBD = new iCom_BusinessData.UsuarioDireccion();
                return oBD.Consultar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        //
        public DataTable Insertar(iCom_BusinessEntity.UsuarioDireccion oBE)
        {
            try
            {
                iCom_BusinessData.UsuarioDireccion oBD = new iCom_BusinessData.UsuarioDireccion();
                return oBD.Insertar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //
        public DataTable Actualizar(iCom_BusinessEntity.UsuarioDireccion oBE)
        {
            try
            {
                iCom_BusinessData.UsuarioDireccion oBD = new iCom_BusinessData.UsuarioDireccion();
                return oBD.Actualizar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
