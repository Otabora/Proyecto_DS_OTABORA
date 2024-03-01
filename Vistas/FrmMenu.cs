using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DS_OTABORA.Vistas
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnPreclinica_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnConsultas_Click(object sender, EventArgs e)
        {
            abrirformulario(new Vistas.FrmCitas());
        }

        private void BtnPreclinica_Click_1(object sender, EventArgs e)
        {
            abrirformulario(new Vistas.FrmPreclinica());
        }
        public void abrirformulario(object formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)

                this.PanelContenedor.Controls.RemoveAt(0);

            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            HomeLabel.Text = fh.Text;
            fh.Show();
        }

        private void BtnPacientes_Click(object sender, EventArgs e)
        {
            abrirformulario(new Vistas.FrmPacientes());
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            LblUsuario.Text = $"@{Clases.Auth.USERNAME} {Clases.Auth.ROL}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirformulario(new Vistas.FrmPreclinica());
        }

        private void BtnDoctores_Click(object sender, EventArgs e)
        {
            abrirformulario(new Vistas.FrmDoctores());
        }

        private void BtnMenudos_Click(object sender, EventArgs e)
        {
            abrirformulario(new Vistas.FrmEmegencias());
        }

        private void TimerFecha_Tick(object sender, EventArgs e)
        {
            //LblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            string dia, mes, anio, fecha;
            dia = DateTime.Now.ToString("dddd");
            mes = DateTime.Now.ToString("MM");
            anio = DateTime.Now.ToString("yyyy");

            fecha = dia + " , " + mes + " / " + anio;
            //LblFecha.Text = fecha;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Vistas.FrmMenudos tools = new  Vistas.FrmMenudos();
            tools.Show();
            this.Close();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            abrirformulario(new Vistas.frmconsulta());
        }
    }
}
