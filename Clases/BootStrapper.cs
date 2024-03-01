using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Data;

namespace Proyecto_DS_OTABORA.Clases
{
    internal class BootStrapper
    {
        
        Clases.DBAccess dba = new Clases.DBAccess();
        Clases.ConexionSQLServer consql = new Clases.ConexionSQLServer();
        Clases.Helpers h = new Clases.Helpers();
        string file_config = @"C:\Data Sistema\Configuracion.accdb";

        public bool revisarArchivoConfig()
        {
            bool resp = false;
            if (File.Exists(file_config)) { 
                resp = true;
            }
            return resp;
        
        }
        public bool RevisaInfoArchivoConfig()
        {
            bool resp = false;
            DataTable data = dba.Find("CONFIG_SERVER");
            if (data.Rows.Count>0)
            {
                resp = true;
                DataRow info = data.Rows[0];
                Clases.Entorno.SERVER = info["SERVER_NAME"].ToString();
                Clases.Entorno.DATABASE = info["DATABASE_NAME"].ToString();
                Clases.Entorno.USER = info["USER_DB"].ToString();
                Clases.Entorno.PWD = info["USER_PWD"].ToString();
                Clases.Entorno.USER_WIN = info["USER_SO"].ToString();

                consql.actualizarConexionSQLSever();
            }
            else
            {
                h.Advertencia("ERROR FATAL, NO SE CARGARON LOS DATOS DEL ARCHIVO DE CONFIGURACION");
            }
            data.Dispose();
            return resp;
        }
    }
}
