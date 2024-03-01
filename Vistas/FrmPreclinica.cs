using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Proyecto_DS_OTABORA.Vistas
{
    public partial class FrmPreclinica : Form
    {
        Clases.Helpers h = new Clases.Helpers();
        Clases.DB db = new Clases.DB();
        string id_preclinica, id_paciente, fechaevalu, estatura, peso, presion, diagnostico, recomendaciones;
        public FrmPreclinica()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ListarPreClinica(TxtBuscar.Text.Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(Listapreclinica);
            tabControl1.TabPages.Add(FormPreclinica);
            CmbPaciente.Enabled = true;
        }

        private void FrmPreclinica_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(FormPreclinica);
            BtnEdit.Enabled= false;
            BtnEstado.Enabled= false;
            ListarPreClinica();
            GetPacientes();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (h.Confirmar("Desea Cancelar la Operacion")== true)
            {
                tabControl1.TabPages.Add(Listapreclinica);
                tabControl1.TabPages.Remove(FormPreclinica);
            }
        }

        private void Listapreclinica_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            
            string smg = "Desea Actualizar los datos del Paciente";
            if (h.Question(smg) == true)
            {
                SetValues();
                string actualizar = $"FECHA_EVALU='{fechaevalu}',ESTATURA='{estatura}',PESO='{peso}',TEMP_PRESION='{presion}',DIAGNOSTICO='{diagnostico}',RECOMENDACIONES='{recomendaciones}'";
                string condicion = $"ID_PRECLINICA='{id_preclinica}'";

                if (db.Update("PRECLINICA", actualizar, condicion) > 0)
                {
                    ClearForm();
                    h.Confirmar("lOS DATOS SE ACTUALIZARON CON EXITO");
                }
            }
            tabControl1.TabPages.Remove(FormPreclinica);
            tabControl1.TabPages.Add(Listapreclinica);
            ListarPreClinica();
            BtnEdit.Enabled = false;
            BtnEstado.Enabled = false;
           

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            CmbPaciente.Enabled= false;
            if (DgvData.Rows.Count > 0)
            {
                tabControl1.TabPages.Add(FormPreclinica);
                tabControl1.TabPages.Remove(Listapreclinica);
                string _paciente = DgvData.CurrentRow.Cells[0].Value.ToString();
                Getpreclinica(_paciente);

            }
        }

        private void DgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEdit.Enabled = true;
            BtnEstado.Enabled = true;
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            if (h.Confirmar("Desea Cancelar el registro") == true)
            {
                ClearForm();
                tabControl1.TabPages.Remove(FormPreclinica);
                tabControl1.TabPages.Add(Listapreclinica);
            }
        }

        private void CmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            Reportes.PreClinica.FrmReporteGnralPreClinica rptgpreclinica = new Reportes.PreClinica.FrmReporteGnralPreClinica();
            rptgpreclinica.Show();
        }

        private void GetPacientes()
        {
            string tablename = "PACIENTES AS P";
            string campos= "P.CODIGO_PA,P.NOMBRE,P.ESTADO";
            
            DataTable data = new DataTable();
            data= db.Find(tablename, campos);

            DataRow dtrow = data.NewRow();
           
            dtrow[0] = -1;
            dtrow[1] ="Seleccione un Paciente";
            dtrow[2] ="Activo";
            data.Rows.InsertAt(dtrow,0);

            CmbPaciente.DataSource = data;
            CmbPaciente.DisplayMember = "NOMBRE";
            CmbPaciente.ValueMember = "CODIGO_PA";


            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (DataRow row in data.Rows)
            {
                collection.Add(Convert.ToString(row["NOMBRE"]));
            }
            CmbPaciente.AutoCompleteCustomSource = collection;
            CmbPaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbPaciente.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void FormPreclinica_Click(object sender, EventArgs e)
        {
            
        }  
        private void SetValues()
        {
            id_preclinica = TxtidPreclinica.Text;
            id_paciente = CmbPaciente.SelectedValue.ToString() ;
            fechaevalu = DtEvalucion.Text;
            estatura = TxtEstatura.Text;
            peso = TxtPeso.Text;
            presion = TxtPresion.Text;
            diagnostico = TxtDiagnostico.Text;
            recomendaciones = TxtRecomenda.Text;
        }

        private void ClearForm()
        {
            TxtidPreclinica.Clear();
            CmbPaciente.SelectedIndex = 0;
            TxtEstatura.Clear();
            TxtPeso.Clear();
            TxtPresion.Clear();
            TxtDiagnostico.Clear();
            TxtRecomenda.Clear();
        }
        private void Getpreclinica(string cod_preclinica)
        {
            DataTable preclinica = db.Find("PRECLINICA", "*", $"ID_PRECLINICA='{cod_preclinica}'");
            if (preclinica.Rows.Count > 0)
            {
                DataRow info = preclinica.Rows[0];
                TxtidPreclinica.Text = info["ID_PRECLINICA"].ToString();
                CmbPaciente.Text = info["ID_PACIENTE"].ToString();
                DtEvalucion.Text = info["FECHA_EVALU"].ToString();
                TxtEstatura.Text = info["ESTATURA"].ToString();
                TxtPeso.Text = info["PESO"].ToString();
                TxtPresion.Text = info["TEMP_PRESION"].ToString();
                TxtDiagnostico.Text = info["DIAGNOSTICO"].ToString();
                TxtRecomenda.Text = info["RECOMENDACIONES"].ToString();

                BtnGuardar.Enabled = false;
            }
        }
        private void ListarPreClinica(string codigo_pa = "")
        {
            DataTable preclinica;
            if (codigo_pa == "")
            {
                preclinica = db.Find($"VIEWPRECLINICA","*");
            }
            else
            {
                string condicion = $"NOMBRE LIKE '%{codigo_pa}%'";
                preclinica = db.Find($"VIEWPRECLINICA", "*", condicion);
            }

            DgvData.Rows.Clear();

            string _id_preclinica, _id_paciente, _fecha, _estatura, _peso, _presion, _diagnostico, _recomenda;

            foreach (DataRow paciente in preclinica.Rows)
            {
                
                _id_preclinica = paciente["ID_PRECLINICA"].ToString();
                _id_paciente = paciente[1].ToString();
                _fecha = paciente["FECHA_EVALU"].ToString();
                _estatura = paciente["ESTATURA"].ToString();
                _peso = paciente["PESO"].ToString();
                _presion = paciente["TEMP_PRESION"].ToString();
                _diagnostico = paciente["DIAGNOSTICO"].ToString();
                _recomenda = paciente["RECOMENDACIONES"].ToString();

                DgvData.Rows.Add(_id_preclinica, _id_paciente, _fecha, _estatura, _peso, _presion, _diagnostico, _recomenda);
            }
            preclinica.Dispose();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            SetValues();
            string columnas = "ID_PACIENTE,FECHA_EVALU,ESTATURA,PESO,TEMP_PRESION,DIAGNOSTICO,RECOMENDACIONES";
            string valores = $"'{id_paciente}','{fechaevalu}','{estatura}','{peso}','{presion}','{diagnostico}','{recomendaciones}'";

            if (db.Save("PRECLINICA", columnas, valores))
            {
                h.Advertencia("El Registro se Guardo Con Exito!!");
                ClearForm();
                CmbPaciente.Focus();
                tabControl1.TabPages.Remove(FormPreclinica);
                tabControl1.TabPages.Add(Listapreclinica);
            }
        }
    }
}
