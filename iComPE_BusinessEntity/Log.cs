namespace iCom_BusinessEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Log
    {
        public int idlog { get; set; }
        public int idusuario { get; set; }
        public string modulo { get; set; }
        public string descripcion { get; set; }
        public Nullable<System.DateTime> fechamov { get; set; }
    }
}
