using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace Proyecto_DS_OTABORA.Clases
{
    internal class DB:Clases.ConexionSQLServer
    {
        Clases.Helpers h = new Clases.Helpers();
        SqlCommand com;
        SqlDataReader reader;
        DataTable data;

        string Query;
        //metodo para guardar
        public bool Save(string tablename,string campos,string valores)
        {
            bool resp= false;
            Query = $"INSERT INTO {tablename}({campos})VALUES({valores})";
            try
            {
                //ejecutamos la consulta
                com = new SqlCommand(Query,ConSQL);
                AbrirConexion();
                Int64 ri = com.ExecuteNonQuery();
                if (ri>0)
                {
                    resp = true;
                }
                com.Dispose();
                CerrarConexion();
            }
            catch (SqlException error)
            {
                h.Advertencia(error.Message);
            }
            finally {
                TerminarConexion();
            }
            return resp;
        }
        //termina metodo para guardar
        //
        public bool Exists(string tablename, string campo, string valor)
        {
            bool resp = false;
            Query = $"SELECT * FROM {tablename} WHERE {campo}={valor}";

            try
            {
                com = new SqlCommand (Query,ConSQL);
                AbrirConexion();
                reader = com.ExecuteReader();

                if (reader.Read())
                {
                    resp=true;
                }
                reader.Close();
                com.Dispose();
                CerrarConexion();
            }
            catch (SqlException error)
            {

                h.Advertencia(error.Message);
            }
            finally
            {
                TerminarConexion();
            }
            return resp;
        }
        public DataTable Find(string tablename, string campos, string condicion = "", string orderby = "", bool debug = false, string buscar="")
        {
            data = new DataTable();
            if (condicion == "" && orderby == "")
            {
                Query = $"SELECT {campos} FROM {tablename}";
            }
            else if (condicion != "" && orderby == "")
            {
                Query = $"SELECT {campos} FROM {tablename} WHERE {condicion}";
            }
            else if (condicion == "" && orderby != "")
            {
                Query = $"SELECT {campos} FROM {tablename} WHERE {orderby}";
            }
            else if (condicion != "" && orderby != "")
            {
                Query = $"SELECT {campos} FROM {tablename} WHERE{condicion} ORDER BY {orderby}";
            }
            else if (buscar !="" && orderby == "" && condicion!="")
            {
                Query = $"SELECT {campos} FROM {tablename} WHERE {condicion} LIKE %{buscar}%";
            }
            try
            {
                com = new SqlCommand(Query,ConSQL);
                AbrirConexion();
                //reader toma la informacion
                reader = com.ExecuteReader();
                //finde reader
                //recordset toma la informacion de reader y la pasa al datagrewview
                data.Load(reader);
                //fin de recordset
                //cerrar todo
                reader.Close();
                com.Dispose();
                CerrarConexion();
            }
            catch (SqlException error)
            {
                h.Advertencia($"Error al Complilar la informacion {error}");
            }
            finally
            {
                TerminarConexion();
            }
            return data;
        }
        //metodo para eliminar
        public int Destroy(string tablename, string condicion = "")
        {
            int rd = 0;
            if (condicion == "")
            {
                Query = $"DELETE FROM {tablename}";
            }
            else
            {
                Query = $"DELETE FROM {tablename} WHERE {condicion}";
            }

            rd = rawSQL(Query); ;
            return rd;
        }
        //finde metodo de eliminar
        public int Update(string tablename, string data, string condicion = "")
        {
            int ru = 0;
            if (condicion == "")
            {
                Query = $"UPDATE {tablename} SET {data}";
            }
            else
            {
                Query = $"UPDATE {tablename} SET {data} WHERE {condicion}";
            }
            ru = rawSQL(Query);
            return ru;
        }
        //Reutilizacion de Coidgo para eliminar actualizar y guardar
        private int rawSQL(string _query)
        {
            int ra = 0;
            try
            {
                com = new SqlCommand(_query, ConSQL);
                AbrirConexion();
                ra = com.ExecuteNonQuery();

                CerrarConexion();
                com.Dispose();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                TerminarConexion();
            }
            return ra;
        }
        public string GetLastEmergenciaId()
        {
            string lastEmergencia = string.Empty;
            Query = "SELECT TOP 1 ID FROM EMERGENCIAS ORDER BY ID DESC";

            try
            {
                com = new SqlCommand(Query, ConSQL);
                AbrirConexion();
                object result = com.ExecuteScalar();
                if (result != null)
                {
                    lastEmergencia = result.ToString();
                }
            }
            catch (SqlException error)
            {
                h.Advertencia($"Error al obtener el último ID de Emergencia: {error.Message}");
            }
            finally
            {
                CerrarConexion();
            }

            return lastEmergencia;
        }
        public string GetLastCita()
        {
            string lastEmergencia = string.Empty;
            Query = "SELECT TOP 1 ID_CITA FROM CITAS ORDER BY ID_CITA DESC";

            try
            {
                com = new SqlCommand(Query, ConSQL);
                AbrirConexion();
                object result = com.ExecuteScalar();
                if (result != null)
                {
                    lastEmergencia = result.ToString();
                }
            }
            catch (SqlException error)
            {
                h.Advertencia($"Error al obtener el último ID de Emergencia: {error.Message}");
            }
            finally
            {
                CerrarConexion();
            }

            return lastEmergencia;
        }
    }
}
