using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Proyecto_DS_OTABORA.Clases
{
    internal class DBAccess:Clases.ConexionAccess
    {
        Clases.Helpers h = new Clases.Helpers();
        OleDbCommand com;
        OleDbDataReader reader;
        DataTable recordset;
        string Query;

        public DataTable Find(string tabla) {
            recordset = new DataTable();
            Query = $"SELECT * FROM {tabla}";

            try
            {
                com = new OleDbCommand(Query, ConAccess);
                AbrirConexion();
                reader = com.ExecuteReader();
                recordset.Load(reader);

                reader.Close();
                com.Dispose();
                CerrarConexion();
            }
            catch (OleDbException error)
            {
                h.Advertencia(error.Message);
            }
            finally{
                terminarConexion();
            }
            return recordset;
        }
    }
}
