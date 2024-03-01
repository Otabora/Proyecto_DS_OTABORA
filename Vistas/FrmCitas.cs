using Proyecto_DS_OTABORA.Clases;
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
    public partial class FrmCitas : Form
    {
        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();
        private int idEmergencia = 1;
        string idcita, idpaciente, iddoctor, fechacita, idservicio, idconsultorio, diagnostico, observaciones, fechanewcita, estadocita;
        public FrmCitas()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void AgregarCitas_Click(object sender, EventArgs e)
        {

        }

        private void FrmCitas_Load(object sender, EventArgs e)
        {
            string lastEmergenciaId = db.GetLastCita();

            if (!string.IsNullOrEmpty(lastEmergenciaId))
            {
                // Convertir el último ID de muestra a entero y agregar 1 para el próximo ID
                idEmergencia = int.Parse(lastEmergenciaId) + 1;
            }
            TxtCita.Text = idEmergencia.ToString();
            TxtCita.Enabled = false;
            //////load aquiiiii
            tabControl1.TabPages.Remove(AgregarCitas);
            BtnEditarpa.Enabled=false;
            BtnEstadopa.Enabled=false;
            ListarCita();
            GetPaciente();
            GetDoctor();
            GetConsultorio();
            GetServicio();
        }
        private void GetPaciente()
        {
            string tablename = "PACIENTES AS P";
            string campos = "P.CODIGO_PA,P.NOMBRE,P.ESTADO";

            DataTable data = new DataTable();
            data = db.Find(tablename, campos);

            DataRow dtrow = data.NewRow();

            dtrow[0] = -1;
            dtrow[1] = "Seleccione un Paciente";
            dtrow[2] = "Activo";
            data.Rows.InsertAt(dtrow, 0);

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

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            string smg = "Desea Actualizar los datos del Paciente";
            if (h.Question(smg) == true)
            {
                SetValues();
                string actualizar = $"ID_PACIENTE='{idpaciente}',ID_DOCTOR='{iddoctor}',FECHA_CITA='{fechacita}',ID_SERVICIO='{idservicio}',ID_CONSULTORIO='{idconsultorio}',DIAGNOSTICO='{diagnostico}',OBSERVACIONES='{observaciones}',FECHA_NEWCITA='{fechanewcita}'";
                string condicion = $"ID_CITA='{idcita}'";

                if (db.Update("CITAS", actualizar, condicion) > 0)
                {
                    ClearForm();
                    h.Confirmar("lOS DATOS SE ACTUALIZARON CON EXITO");
                }
            }
            tabControl1.TabPages.Remove(AgregarCitas);
            tabControl1.TabPages.Add(ListaCitas);
            ListarCita();
            BtnEditarpa.Enabled = false;
            BtnEstadopa.Enabled = false;
        }
        private void GetCitas(string cod_cita)
        {
            DataTable cita = db.Find("CITAS", "*", $"ID_CITA='{cod_cita}'");
            if (cita.Rows.Count > 0)
            {
                
                DataRow info = cita.Rows[0];
                TxtCita.Text = info["ID_CITA"].ToString();
                CmbPaciente.SelectedValue = info["ID_PACIENTE"].ToString();
                CmbDoctor.SelectedValue = info["ID_DOCTOR"].ToString();
                DtFechacita.Text = info["FECHA_CITA"].ToString();
                CmbServ.SelectedValue = info["ID_SERVICIO"].ToString();
                CmbConsul.SelectedValue = info["ID_CONSULTORIO"].ToString();
                TxtDiagnostico.Text = info["DIAGNOSTICO"].ToString();
                TxtObservacion.Text = info["OBSERVACIONES"].ToString();
                DtNuevaCita.Text = info["FECHA_NEWCITA"].ToString();
                

                BtnGuardar.Enabled = false;
            }
        }
        private void ListarCita(string codigo_ci = "")
        {
            DataTable citas;
            if (codigo_ci == "")
            {
                citas = db.Find($"VIEWCITAS", "*");
            }
            else
            {
                string condicion = $"NOMBRE LIKE '%{codigo_ci}%'";
                citas = db.Find($"VIEWPRECLINICA", "*", condicion);
            }

            DgvData.Rows.Clear();

            string _idcita, _id_paciente, _iddoctor, _fecha, _idservicio, _idconsulta, _diagnostico, _observaciones,_fechanew,_estado;

            foreach (DataRow paciente in citas.Rows)
            {

                _idcita = paciente["ID_CITA"].ToString();
                _id_paciente = paciente[1].ToString();
                _iddoctor= paciente[2].ToString();
                _fecha = paciente["FECHA_CITA"].ToString();
                _idservicio = paciente["ID_SERVICIO"].ToString();
                _idconsulta = paciente["ID_CONSULTORIO"].ToString();
                _diagnostico = paciente["DIAGNOSTICO"].ToString();
                _observaciones = paciente["OBSERVACIONES"].ToString();
                _fechanew = paciente["FECHA_NEWCITA"].ToString();
                _estado = paciente["ESTADO_CITA"].ToString();

                DgvData.Rows.Add(_idcita, _id_paciente, _iddoctor, _fecha, _idservicio, _idconsulta, _diagnostico, _observaciones, _fechanew, _estado);
            }
            citas.Dispose();
        }

        private void DgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEditarpa.Enabled = true;
            BtnEstadopa.Enabled = true;
        }

        private void BtnEditarpa_Click(object sender, EventArgs e)
        {
           
            if (DgvData.Rows.Count > 0)
            {
                tabControl1.TabPages.Add(AgregarCitas);
                tabControl1.TabPages.Remove(ListaCitas);
                string _paciente = DgvData.CurrentRow.Cells[0].Value.ToString();
                GetCitas(_paciente);

            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(ListaCitas);
            tabControl1.TabPages.Add(AgregarCitas);
            BtnEditar.Enabled = false;
        }

        private void GetDoctor()
        {
            string tablename = "DOCTORES AS P";
            string campos = "P.ID_DOCTOR,P.NOMBRES,P.ESTADO";

            DataTable data = new DataTable();
            data = db.Find(tablename, campos);

            DataRow dtrow = data.NewRow();

            dtrow[0] = -1;
            dtrow[1] = "Seleccione un Doctor";
            dtrow[2] = "Activo";
            data.Rows.InsertAt(dtrow, 0);

            CmbDoctor.DataSource = data;
            CmbDoctor.DisplayMember = "NOMBRES";
            CmbDoctor.ValueMember = "ID_DOCTOR";


            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (DataRow row in data.Rows)
            {
                collection.Add(Convert.ToString(row["NOMBRES"]));
            }
            CmbDoctor.AutoCompleteCustomSource = collection;
            CmbDoctor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbDoctor.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void GetConsultorio()
        {
            string tablename = "CONSULTORIO AS P";
            string campos = "P.ID_CONSUL,P.NUM_CONSULTORIO";

            DataTable data = new DataTable();
            data = db.Find(tablename, campos);

            DataRow dtrow = data.NewRow();

            dtrow[0] = -1;
            dtrow[1] = "Seleccione un Consultorio";
            data.Rows.InsertAt(dtrow, 0);

            CmbConsul.DataSource = data;
            CmbConsul.DisplayMember = "NUM_CONSULTORIO";
            CmbConsul.ValueMember = "ID_CONSUL";


            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (DataRow row in data.Rows)
            {
                collection.Add(Convert.ToString(row["NUM_CONSULTORIO"]));
            }
            CmbConsul.AutoCompleteCustomSource = collection;
            CmbConsul.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbConsul.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void GetServicio()
        {
            string tablename = "SERVICIO AS P";
            string campos = "P.ID_SERVICIO,P.DESCRIPCION,P.ESTADO";

            DataTable data = new DataTable();
            data = db.Find(tablename, campos);

            DataRow dtrow = data.NewRow();

            dtrow[0] = -1;
            dtrow[1] = "Seleccione Tipo de Servicio";
            dtrow[2] = "ACTIVO";
            data.Rows.InsertAt(dtrow, 0);

            CmbServ.DataSource = data;
            CmbServ.DisplayMember = "DESCRIPCION";
            CmbServ.ValueMember = "ID_SERVICIO";


            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (DataRow row in data.Rows)
            {
                collection.Add(Convert.ToString(row["DESCRIPCION"]));
            }
            CmbServ.AutoCompleteCustomSource = collection;
            CmbServ.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CmbServ.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void ListaCitas_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            if (h.Confirmar("Desea Cancelar el registro") == true)
            {
                ClearForm();
                tabControl1.TabPages.Remove(AgregarCitas);
                tabControl1.TabPages.Add(ListaCitas);
            }
        }
        private void ClearForm()
        {
            CmbPaciente.SelectedIndex = 0;
            CmbDoctor.SelectedIndex = 0;
            TxtDiagnostico.Clear();
            TxtObservacion.Clear();
            CmbServ.SelectedIndex = 0;
            CmbConsul.SelectedIndex = 0;
        }
        private void SetValues()
        {
            idcita = TxtCita.Text;
            idpaciente = CmbPaciente.SelectedValue.ToString();
            iddoctor = CmbDoctor.SelectedValue.ToString();
            fechacita = DtFechacita.Text;
            idservicio= CmbServ.SelectedValue.ToString();
            idconsultorio = CmbConsul.SelectedValue.ToString();
            diagnostico = TxtDiagnostico.Text;
            observaciones = TxtObservacion.Text;
            fechanewcita = DtNuevaCita.Text;

        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            SetValues();
            string columnas = "ID_PACIENTE,ID_DOCTOR,FECHA_CITA,ID_SERVICIO,ID_CONSULTORIO,DIAGNOSTICO,OBSERVACIONES,FECHA_NEWCITA";
            string valores = $"'{idpaciente}','{iddoctor}','{fechacita}','{idservicio}','{idconsultorio}','{diagnostico}','{observaciones}','{fechanewcita}'";

            if (db.Save("CITAS", columnas, valores))
            {
                h.Exito("El Registro se Guardo Con Exito!!");
                ClearForm();
                CmbPaciente.Focus();
                tabControl1.TabPages.Remove(AgregarCitas);
                tabControl1.TabPages.Add(ListaCitas);
                ListarCita();
            }
        }
    }
}
