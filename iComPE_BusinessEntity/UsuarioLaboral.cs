namespace iCom_BusinessEntity
{
    public class UsuarioLaboral
    {
        public int idusuariolaboral { get; set; }
        public int idusuario { get; set; }
        public bool labora { get; set; }
        public string nombreempresa { get; set; }
        public string puesto { get; set; }
        public string dias { get; set; }
        public System.DateTime horariodesde { get; set; }
        public System.DateTime horariohasta { get; set; }
        public string telefono { get; set; }
        public string descripciondoncente { get; set; }
        public System.DateTime fechamov { get; set; }
    }
}
