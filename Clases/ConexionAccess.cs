using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Proyecto_DS_OTABORA.Clases
{
    internal class ConexionAccess
    {
        Clases.Helpers h = new Clases.Helpers();
        public static string cadena_conexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Data Sistema\Configuracion.accdb;Jet OLEDB:Database Password=123;";
        public static OleDbConnection ConAccess = new OleDbConnection(cadena_conexion);

        public void AbrirConexion() { 
            try {
                ConAccess.Open(); 

            } 
            
            catch(OleDbException error){
                h.Advertencia(error.Message);
            }
        }
        public void CerrarConexion() {
            try
            {
                ConAccess.Close();
            }
            catch (OleDbException error)
            {

                h.Advertencia(error.Message);
            }
        }
        public void terminarConexion() {
            if (ConAccess.State == ConnectionState.Open)
            {
                ConAccess.Close();
            }
        }
    }
}
