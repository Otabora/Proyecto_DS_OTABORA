using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DS_OTABORA.Vistas.Autenticacion
{
    public partial class FrmLogin : Form
    {
        Clases.BootStrapper bs = new Clases.BootStrapper();
        Clases.Auth auth = new Clases.Auth();
        Clases.Helpers h = new Clases.Helpers();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (bs.revisarArchivoConfig () == true) {

                if(bs.RevisaInfoArchivoConfig() == true)
                {
                    auth.registerUserAdmin();
                }
            }
            else
            {
                MessageBox.Show("Error al Cargar el Archivo de Configuracion🔥");
                Application.Exit();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = TxtUsuario.Text.Trim();
            string clave = TxtClave.Text.Trim();

            if (auth.makeLogin(username, clave) == true)
            {

                Vistas.FrmMenu menu = new Vistas.FrmMenu();
                menu.ShowDialog();
                this.Hide();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (h.Confirmar("Desea Cancelar la Operacion en Curso?"))
            {
                
                TxtUsuario.Clear();
                TxtClave.Clear();
                TxtUsuario.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            TxtClave.UseSystemPasswordChar = TxtClave.UseSystemPasswordChar == true ? false : true;

        }

        private void TxtClave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
