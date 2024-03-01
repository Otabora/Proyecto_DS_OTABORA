using Proyecto_DS_OTABORA.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DS_OTABORA.Vistas
{
    public partial class FrmEmegencias : Form
    {
        Clases.DB DB = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();
        private int idEmergencia = 1;
        string codigo, nombre, especie, fecha, motivo, detalle, diagnostico, receta;

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Vistas.FrmBuscarMascota buscar = new Vistas.FrmBuscarMascota();
            this.AddOwnedForm(buscar);
            buscar.Show();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            SetValues();
            string columnas = "FECHA,MASCOTA_CODGIO,MOTIVO,DETALLE,DIAGNOSTICO,RECETA";
            string valores = $"'{fecha}','{codigo}','{motivo}','{detalle}','{diagnostico}','{receta}'";

            if (DB.Save("EMERGENCIAS", columnas, valores))
            {
                h.Advertencia("El Registro se Guardo Con Exito!!");
                
                TxtNombre.Focus();
                ClearFrom();

            }
        }

        public FrmEmegencias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reportes.FrmReporteGenralEmergencia rptgpaciente = new Reportes.FrmReporteGenralEmergencia();
            rptgpaciente.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void DtFecha_ValueChanged(object sender, EventArgs e)
        {
            DtFecha.Value = new DateTime(2024, 02, 24);
        }

        private void TxtReceta_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEmegencias_Load(object sender, EventArgs e)
        {
            string lastEmergenciaId = DB.GetLastEmergenciaId();

            if (!string.IsNullOrEmpty(lastEmergenciaId))
            {
                // Convertir el último ID de muestra a entero y agregar 1 para el próximo ID
                idEmergencia = int.Parse(lastEmergenciaId) + 1;
            }

            // Mostrar el próximo ID de muestra en el campo TxtMuestra
            TxtEmergencia.Text = idEmergencia.ToString();
            TxtNombre.Enabled = false;
            TxtCodigo.Enabled = false;
            TxtEmergencia.Enabled = false;
        }

        public void recibirmascota(string codigo, string nombre, string especie)
        {
            TxtCodigo.Text = codigo;
            TxtNombre.Text = nombre;
            TxtEspecie.Text = especie;
        }

        private void SetValues()
        {
            codigo = TxtCodigo.Text;
            nombre = TxtNombre.Text;
            especie = TxtEspecie.Text;
            motivo = TxtMotivo.Text;
            detalle = TxtDetalle.Text;
            diagnostico = TxtDiagnostico.Text;
            receta = TxtReceta.Text;
        }
        private void ClearFrom()
        {
            TxtCodigo.Clear();
            TxtDetalle.Clear();
            TxtMotivo.Clear();
            TxtDiagnostico.Clear();
            TxtReceta.Clear();
        }
    }
}
