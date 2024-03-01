using Proyecto_DS_OTABORA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;

namespace Proyecto_DS_OTABORA.Vistas
{
    public partial class FrmBuscarMascota : Form
    {
        Clases. DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();
        public FrmBuscarMascota()
        {
            InitializeComponent();
        }

        private void FrmBuscarMascota_Load(object sender, EventArgs e)
        {

        }

        private void buscarmascota(string codigo)
        {
            DataTable pacientes = new DataTable();
            string campos = "CODIGO,NOMBRE,ESPECIE,EDAD";
            pacientes = db.Find("MASCOTAS",campos,$"NOMBRE LIKE '%{codigo}%'");

            DgvData.Rows.Clear();
            string _codigo, _nombre, _especie, _anio;
            foreach (DataRow infopaciente in pacientes.Rows)
            {
               _codigo = infopaciente["CODIGO"].ToString();
                _nombre = infopaciente["NOMBRE"].ToString();
                _especie = infopaciente["ESPECIE"].ToString();
                _anio = infopaciente["EDAD"].ToString();

                DgvData.Rows.Add(_codigo, _nombre, _especie, _anio);

            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarmascota(TxtBuscar.Text.Trim());
            }
        }

        private void DgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvData.Rows.Count>0)
            {
                string codigo, nombre, especie;
                codigo = DgvData.CurrentRow.Cells[0].Value.ToString();
                 nombre = DgvData.CurrentRow.Cells[1].Value.ToString();
                especie = DgvData.CurrentRow.Cells[2].Value.ToString();

                Vistas.FrmEmegencias emergencia = new Vistas.FrmEmegencias();
                emergencia = ((Vistas.FrmEmegencias)Owner);

                emergencia.recibirmascota(codigo,nombre,especie);
                this.Close();
            }
        }
    }
}
