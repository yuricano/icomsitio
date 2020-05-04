using System;
using System.Data;

public class Log
{
    public static string _Log(int Id, string Modulo, string Descripcion)
    {
        DataTable dtLog = new DataTable();
        
        try
        {
            iCom_BusinessEntity.Log oBE = new iCom_BusinessEntity.Log();

            oBE.idusuario = Id;
            oBE.modulo = Modulo;
            oBE.descripcion = "Sitio Web - " + Descripcion;
            iCom_BusinessLogic.Log oBL = new iCom_BusinessLogic.Log();

            dtLog = oBL.Insertar(oBE);

            return string.Empty;
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
}