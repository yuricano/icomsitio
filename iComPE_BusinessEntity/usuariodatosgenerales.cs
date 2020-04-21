namespace iCom_BusinessEntity
{
    public class UsuarioDatosGenerales
    { 
        public int iddatosgenerales { get; set; }
        public int idusuario { get; set; }
        public string nombre { get; set; }
        public string appaterno { get; set; }
        public string apmaterno { get; set; }
        public int idmodeloeducativo { get; set; }
        public int idperiodoescolar { get; set; }
        public string matricula { get; set; }
        public int idcarrera { get; set; }
        public System.DateTime fechanacimiento { get; set; }
        public string nacionalidad { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public int idsexo { get; set; }
        public int idestadocivil { get; set; }
        public int hijos { get; set; }
        public string curp { get; set; }
        public string escuelaprocedencia { get; set; }
        public System.DateTime fechamov { get; set; }
    }
}
