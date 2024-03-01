using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_DS_OTABORA.Clases
{
    internal class ConexionSQLServer:Clases.Entorno
    {
        Clases.Helpers h = new Clases.Helpers();
        public static string cadena_conexion_sql;
        public static SqlConnection ConSQL = new SqlConnection();
        public void actualizarConexionSQLSever()
        {
            cadena_conexion_sql = $"Server={SERVER};DataBase={DATABASE};User Id={USER};Pwd={PWD}";
            ConSQL = new SqlConnection(cadena_conexion_sql) ;
        }
        public void AbrirConexion() {
            try
            {
                ConSQL.Open();
            }
            catch (SqlException error)
            {
                h.Advertencia(error.Message);   
            }
        }
        public void CerrarConexion() {
            try
            {
                ConSQL.Close();
            }
            catch (SqlException error)
            {
                h.Advertencia(error.Message);
            }
        }
        public void TerminarConexion() {
            if (ConSQL.State== ConnectionState.Open) {
                ConSQL.Close();
            }
        }
    }
}
