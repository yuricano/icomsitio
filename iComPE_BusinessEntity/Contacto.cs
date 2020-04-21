namespace iCom_BusinessEntity
{
    public class Contacto
    {
        public int idcarrera { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string mensaje { get; set; }
        public System.DateTime fechamov { get; set; }
        public bool activo { get; set; }
    }
}
