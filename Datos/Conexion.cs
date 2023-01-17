using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private static Conexion Con = null;

            private Conexion()
        {
            this.Base = "MiBaseDatos";
            this.Servidor = ".\\SQLENTERPRISE";
            this.Usuario = "sa";
            this.Clave = "a123456.";
        }
        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "";

            }
            catch(Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }
        public static Conexion GetInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
