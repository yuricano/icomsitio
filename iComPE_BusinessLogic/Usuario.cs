using System;
using System.Data;
using iCom_BusinessData;

namespace iCom_BusinessLogic
{
    public class Usuario : conexionGeneral
    {
        public Usuario()
        {
        }

        //
        public DataTable Consultar(iCom_BusinessEntity.Usuario oBE)
        {
            try
            {
                iCom_BusinessData.Usuario oBD = new iCom_BusinessData.Usuario();
                return oBD.Consultar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //
        public DataTable IdUsuario()
        {
            try
            {
                iCom_BusinessData.Usuario oBD = new iCom_BusinessData.Usuario();
                return oBD.idusuario();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //
        public DataTable Insertar(iCom_BusinessEntity.Usuario oBE)
        {
            try
            {
                iCom_BusinessData.Usuario oBD = new iCom_BusinessData.Usuario();
                return oBD.Insertar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //
        public DataTable Actualizar(iCom_BusinessEntity.Usuario oBE)
        {
            try
            {
                iCom_BusinessData.Usuario oBD = new iCom_BusinessData.Usuario();
                return oBD.Actualizar(oBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
