using System;
using System.Data;
using System.Data.SqlClient;

namespace iCom_BusinessData
{
    public class UsuarioLaboral : conexionGeneral
    {
        public UsuarioLaboral()
        {
        }

        //
        public DataTable Consultar(iCom_BusinessEntity.UsuarioLaboral oBE)
        {
            try
            {
                DataTable dtResultado = new DataTable();

                oComando.CommandText = "dbo.spGetUsuarioLaboral";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();
                oParametro = new System.Data.SqlClient.SqlParameter("@idusuario", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idusuario;
                oComando.Parameters.Add(oParametro);

                if (this.Conectar())
                {
                    SqlDataAdapter daResultado = new SqlDataAdapter(oComando);
                    daResultado.Fill(dtResultado);
                    Desconectar();
                }
                return dtResultado;
            }
            catch (Exception ex)
            {
                Desconectar();
                throw ex;
            }
        }

        //
        public DataTable Insertar(iCom_BusinessEntity.UsuarioLaboral oBE)
        {
            try
            {
                DataTable dtResultado = new DataTable();

                oComando.CommandText = "dbo.spInsUsuarioLaboral";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;

                oComando.Parameters.Clear();
                oParametro = new System.Data.SqlClient.SqlParameter("@idusuario", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idusuario;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@labora", System.Data.SqlDbType.Bit);
                oParametro.Value = oBE.labora;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@nombreempresa", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.nombreempresa;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@puesto", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.puesto;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@dias", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.dias;
                oComando.Parameters.Add(oParametro);

                //oParametro = new System.Data.SqlClient.SqlParameter("@horariodesde", System.Data.SqlDbType.DateTime);
                //oParametro.Value = oBE.horariodesde;
                //oComando.Parameters.Add(oParametro);

                //oParametro = new System.Data.SqlClient.SqlParameter("@horariohasta", System.Data.SqlDbType.DateTime);
                //oParametro.Value = oBE.horariohasta;
                //oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@teléfono", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.telefono;
                oComando.Parameters.Add(oParametro);

                if (this.Conectar())
                {
                    SqlDataAdapter daResultado = new SqlDataAdapter(oComando);
                    daResultado.Fill(dtResultado);
                    Desconectar();
                }
                return dtResultado;
            }
            catch (Exception ex)
            {
                Desconectar();
                throw ex;
            }
        }

        public DataTable Actualizar(iCom_BusinessEntity.UsuarioLaboral oBE)
        {
            try
            {
                DataTable dtResultado = new DataTable();

                oComando.CommandText = "dbo.spUpdUsuarioLaboral";
                oComando.CommandType = System.Data.CommandType.StoredProcedure;
                oComando.Parameters.Clear();

                oParametro = new System.Data.SqlClient.SqlParameter("@idusuariolaboral", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idusuariolaboral;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@idusuario", System.Data.SqlDbType.Int);
                oParametro.Value = oBE.idusuario;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@labora", System.Data.SqlDbType.Bit);
                oParametro.Value = oBE.labora;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@nombreempresa", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.nombreempresa;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@puesto", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.puesto;
                oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@dias", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.dias;
                oComando.Parameters.Add(oParametro);

                //oParametro = new System.Data.SqlClient.SqlParameter("@horariodesde", System.Data.SqlDbType.DateTime);
                //oParametro.Value = oBE.horariodesde;
                //oComando.Parameters.Add(oParametro);

                //oParametro = new System.Data.SqlClient.SqlParameter("@horariohasta", System.Data.SqlDbType.DateTime);
                //oParametro.Value = oBE.horariohasta;
                //oComando.Parameters.Add(oParametro);

                oParametro = new System.Data.SqlClient.SqlParameter("@teléfono", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.telefono;

                oParametro = new System.Data.SqlClient.SqlParameter("@descripciondoncente", System.Data.SqlDbType.VarChar);
                oParametro.Value = oBE.descripciondoncente;
                oComando.Parameters.Add(oParametro);

                if (this.Conectar())
                {
                    SqlDataAdapter daResultado = new SqlDataAdapter(oComando);
                    daResultado.Fill(dtResultado);
                    Desconectar();
                }
                return dtResultado;
            }
            catch (Exception ex)
            {
                Desconectar();
                throw ex;
            }
        }
    }
}
