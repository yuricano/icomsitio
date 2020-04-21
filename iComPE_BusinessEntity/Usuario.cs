namespace iCom_BusinessEntity
{
    public class Usuario
    {
        public int idusuario { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public int idusuariotipo { get; set; }
        public System.DateTime fechamov { get; set; }
        public bool activo { get; set; }
    }
}