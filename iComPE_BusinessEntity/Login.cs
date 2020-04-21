namespace iCom_BusinessEntity
{
    public class Login
    {
        int iID;
        string sUsuario;
        string sContrasena;
        int iIdUsuarioTipo;


        public Login()
        {
            ///
        }

        //
        public int id
        {
            get
            {
                return iID;
            }
            set
            {

                if (value >= 0)
                    iID = value;
            }
        }

        //
        public string Usuario
        {
            get
            {
                return sUsuario;
            }
            set
            {
                sUsuario = value;
            }
        }


        //
        public string Contrasena
        {
            get
            {
                return sContrasena;
            }
            set
            {
                sContrasena = value;
            }
        }

        public int UsuarioTipo
        {
            get
            {
                return iIdUsuarioTipo;
            }
            set
            {

                if (value >= 0)
                    iIdUsuarioTipo = value;
            }
        }

    }
}