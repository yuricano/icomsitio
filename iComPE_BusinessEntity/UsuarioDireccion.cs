namespace iCom_BusinessEntity
{
    public class UsuarioDireccion
    {
        public int idusuariodireccion { get; set; }
        public int idusuario { get; set; }
        public int idusuariopadres { get; set; }
        public string calle { get; set; }
        public string numeroexterior { get; set; }
        public string numerointerior { get; set; }
        public string colonia { get; set; }
        public string codigopostal { get; set; }
        public int idciudad { get; set; }
        public int idestado { get; set; }
        public int idpais { get; set; }
        public System.DateTime fechamov { get; set; }
    }
}
