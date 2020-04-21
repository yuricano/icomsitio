using System;
using System.Data;
using iCom_BusinessData;

namespace iCom_BusinessLogic
{
    public class UsuarioDatosGenerales : conexionGeneral
    {
        public UsuarioDatosGenerales()
        {
        }

        //
        public DataTable Consultar(iCom_BusinessEntity.UsuarioDatosGenerales oBE)
        {
            try
            {
                iCom_BusinessData.UsuarioDatosGenerales oBD = new iCom_BusinessData.UsuarioDatosGenerales();
                return oBD.Consultar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        //
        public DataTable Insertar(iCom_BusinessEntity.UsuarioDatosGenerales oBE)
        {
            try
            {
                iCom_BusinessData.UsuarioDatosGenerales oBD = new iCom_BusinessData.UsuarioDatosGenerales();
                return oBD.Insertar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //
        public DataTable Actualizar(iCom_BusinessEntity.UsuarioDatosGenerales oBE)
        {
            try
            {
                iCom_BusinessData.UsuarioDatosGenerales oBD = new iCom_BusinessData.UsuarioDatosGenerales();
                return oBD.Actualizar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
