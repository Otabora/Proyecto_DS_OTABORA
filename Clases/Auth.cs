using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Proyecto_DS_OTABORA.Clases
{
    internal class Auth
    {
        public static string USERNAME;
        public static string ROL;
        public static string NOMBRE;
        public static string GUARDAR;
        public static string ACTUALIZAR;
        public static string ELIMINAR;
        public static string IMPRIMIR;
        public static string REIMPRIMIR;




        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();
        public bool registerUserAdmin()
        {
            bool resp = false;
            if (db.Exists("USUARIOS","USERNAME",$"'Otabora'")== false)
            {
                string username, clave, nombre, genero, fechanac, correo;

                username = "OTABORA";
                clave = BCrypt.Net.BCrypt.HashPassword("123456");
                nombre = "Oscar  Tabora Palma";
                genero = "Hombre";
                fechanac = "24/10/2001";
                correo = "oscartabora33@gmail.com";

                string campos = "USERNAME,CLAVE,NOMBRE,GENERO,FECHA_NAC,CORREO";
                string valores = $"'{username}','{clave}','{nombre}','{genero}','{fechanac}','{correo}'";

                if (db.Save("USUARIOS", campos, valores) == false)
                {
                    campos = "USUARIO, GUARDAR, ACTUALIZAR, ELIMINAR, IMPRIMIR, REIMPRIMIR";
                    valores = $"'{username}', 'N', 'N', 'N','N','N'";
                    db.Save("PERMISOS", campos, valores);
                }

            }
            return resp;
        }
        public bool makeLogin(string username, string clave)
        {
            bool resp = false;
            DataTable data = db.Find("USUARIOS", "*", $"USERNAME='{username}'");

            if (data.Rows.Count > 0)
            {
                DataRow infouser = data.Rows[0];
                string usuario = infouser["USERNAME"].ToString();
                string clave_db = infouser["CLAVE"].ToString();
                string estado = infouser["ESTADO"].ToString();

                USERNAME = usuario;
                ROL = infouser["ROL"].ToString();
                NOMBRE = infouser["NOMBRE"].ToString();
                if (username == usuario && BCrypt.Net.BCrypt.Verify(clave, clave_db) && estado == "ACTIVA")
                {
                    CargarPermisos(usuario);
                    resp = true;
                }
                else
                {
                    h.Advertencia("Las credenciales parecen no ser correctas!");
                }
            }
            else
            {
                h.Advertencia("Usuario no Exisite!");
            }
            return resp;
        }
        private void CargarPermisos(string username)
        {
            DataTable data = db.Find("PERMISOS", "*", $"USUARIO='{username}'");
            if (data.Rows.Count > 0)
            {
                DataRow permisos = data.Rows[0];
                GUARDAR = permisos["GUARDAR"].ToString();
                ACTUALIZAR = permisos["ACTUALIZAR"].ToString();
                ELIMINAR = permisos["ELIMINAR"].ToString();
                IMPRIMIR = permisos["IMPRIMIR"].ToString();
                REIMPRIMIR = permisos["REIMPRIMIR"].ToString();


            }
            else
            {
                h.Advertencia($"Error al cargar los Permisos del USUARIO!! {username}");
            }
            data.Dispose();
        }
    }
}
