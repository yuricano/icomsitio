using System;
using System.Data;

namespace iCom_Generales
{
    public class Filtros
    {
        static DataTable dtDatos = new DataTable();

        // Carrera
        public static DataTable Carrera(int id)
        {
            try
            {
                iCom_BusinessEntity.Carrera oBE = new iCom_BusinessEntity.Carrera();

                oBE.idcarrera = id;
                iCom_BusinessLogic.Carrera oBL = new iCom_BusinessLogic.Carrera();
                dtDatos = oBL.Consultar(oBE);

                return dtDatos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Modelo Educativo
        public static DataTable ModeloEducativo(int id)
        {
            try
            {
                iCom_BusinessEntity.ModeloEducativo oBE = new iCom_BusinessEntity.ModeloEducativo();

                oBE.idmodeloeducativo = id;
                iCom_BusinessLogic.ModeloEducativo oBL = new iCom_BusinessLogic.ModeloEducativo();
                dtDatos = oBL.Consultar(oBE);

                return dtDatos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Periodo Escolar
        public static DataTable PeriodoEscolar(int id)
        {
            try
            {
                iCom_BusinessEntity.PeriodoEscolar oBE = new iCom_BusinessEntity.PeriodoEscolar();

                oBE.idperiodoescolar = id;
                iCom_BusinessLogic.PeriodoEscolar oBL = new iCom_BusinessLogic.PeriodoEscolar();
                dtDatos = oBL.Consultar(oBE);

                return dtDatos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Pais
        public static DataTable Pais(int id)
        {
            try
            {
                iCom_BusinessEntity.Pais oBE = new iCom_BusinessEntity.Pais();

                oBE.idpais = 0;
                iCom_BusinessLogic.Pais oBL = new iCom_BusinessLogic.Pais();
                dtDatos = oBL.Consultar(oBE);

                return dtDatos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Estado
        public static DataTable Estado(int idEstado, int idPais)
        {
            try
            {
                iCom_BusinessEntity.Estado oBE = new iCom_BusinessEntity.Estado();
                oBE.idestado = idEstado;
                oBE.idpais = idPais;
                iCom_BusinessLogic.Estado oBL = new iCom_BusinessLogic.Estado();
                dtDatos = oBL.Consultar(oBE);

                return dtDatos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Ciudad
        public static DataTable Ciudad(int idCiudad, int idEstado)
        {
            try
            {
                iCom_BusinessEntity.Ciudad oBE = new iCom_BusinessEntity.Ciudad();
                oBE.idciudad = idCiudad;
                oBE.idestado = idEstado;
                iCom_BusinessLogic.Ciudad oBL = new iCom_BusinessLogic.Ciudad();
                dtDatos = oBL.Consultar(oBE);

                return dtDatos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
