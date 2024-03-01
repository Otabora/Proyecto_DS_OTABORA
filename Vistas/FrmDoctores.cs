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
    public partial class FrmDoctores : Form
    {
        string id_doctor, nombre, apellido, especialidad, numcolegio, telefono, correo, direccion, fecha,estado;

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (h.Confirmar("Desea Cancelar el registro") == true)
            {
                ClearForm();
                tabControl1.TabPages.Remove(AgreDoc);
                tabControl1.TabPages.Add(Listadoc);
                TxtBuscar.Clear();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(Listadoc);
            tabControl1.TabPages.Add(AgreDoc);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            SetValues();
            string columnas = "NOMBRES,APELLIDOS,ID_ESPECIALIDAD,NUM_COLEGIADO,TELEFONO,CORREO,DIRECCION,FECHA_IN";
            string valores = $"'{nombre}','{apellido}','{especialidad}','{numcolegio}','{telefono}','{correo}','{direccion}','{fecha}'";

            if (db.Save("DOCTORES", columnas, valores))
            {
                h.Advertencia("El Registro se Guardo Con Exito!!");
                ClearForm();
                TxtNombre.Focus();
                tabControl1.TabPages.Remove(AgreDoc);
                tabControl1.TabPages.Add(Listadoc);

            }
        }

        private void DgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEdit.Enabled = true;
            BtnEstado.Enabled = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            
            if (DgvData.Rows.Count > 0)
            {
                tabControl1.TabPages.Add(AgreDoc);
                tabControl1.TabPages.Remove(Listadoc);
                string _paciente = DgvData.CurrentRow.Cells[0].Value.ToString();
                GetInfoDoctores(_paciente);

            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            string smg = "Desea Actualizar los datos del Paciente";
            if (h.Question(smg) == true)
            {
                SetValues();
                string actualizar = $"NOMBRES='{nombre}',APELLIDOS='{apellido}',ID_ESPECIALIDAD='{especialidad}',NUM_COLEGIADO='{numcolegio}',TELEFONO='{telefono}',CORREO='{correo}',DIRECCION='{direccion}',FECHA_IN='{fecha}'";
                string condicion = $"ID_DOCTOR='{id_doctor}'";

                if (db.Update("DOCTORES", actualizar, condicion) > 0)
                {
                    ClearForm();
                    h.Confirmar("lOS DATOS SE ACTUALIZARON CON EXITO");
                }
            }
            tabControl1.TabPages.Remove(AgreDoc);
            tabControl1.TabPages.Add(Listadoc);
            ListarDoctor();
            BtnEdit.Enabled = false;
            BtnEstado.Enabled = false;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            ListarDoctor(TxtBuscar.Text.Trim());
        }

        Clases.DB db = new Clases.DB();
        Clases.Helpers h = new Clases.Helpers();
        public FrmDoctores()
        {
            InitializeComponent();
        }

        private void FrmDoctores_Load(object sender, EventArgs e)
        {
            BtnEdit.Enabled = false;
            BtnEstado.Enabled = false;
            tabControl1.TabPages.Remove(AgreDoc);
            GetEspecialidad();
            ListarDoctor();
        }
        private void GetEspecialidad()
        {
            string tablename = "ESPECIALIDAD AS P";
            string campos = "P.ID_ESPECIALIDAD,P.NOMBRE_ESPEC";

            DataTable data = new DataTable();
            data = db.Find(tablename, campos);

            DataRow dtrow = data.NewRow();

            dtrow[0] = -1;
            dtrow[1] = "Seleccione una Especialidad";
            data.Rows.InsertAt(dtrow, 0);

            CmbEspecial.DataSource = data;
            CmbEspecial.DisplayMember = "NOMBRE_ESPEC";
            CmbEspecial.ValueMember = "ID_ESPECIALIDAD";
        }
        private void SetValues()
        {
            id_doctor = TxtIdDoc.Text;
            nombre = TxtNombre.Text;
            apellido = TxtApellido.Text;
            especialidad = CmbEspecial.SelectedValue.ToString();
            numcolegio = TxtCetificado.Text;
            telefono = TxtTelfono.Text;
            correo = TxtCorreo.Text;
            direccion = TxtDireccion.Text;
            fecha = DtFecha.Text;
        }

        private void ClearForm()
        {
            TxtNombre.Clear();
            TxtApellido.Clear();
            CmbEspecial.SelectedIndex = 0;
            TxtCetificado .Clear();
            TxtTelfono .Clear();
            TxtCorreo .Clear();
            TxtDireccion .Clear();
            
        }
        private void GetInfoDoctores(string n_doctor)
        {
            DataTable doctores = db.Find("DOCTORES", "*", $"ID_DOCTOR='{n_doctor}'");
            if (doctores.Rows.Count > 0)
            {
                DataRow info = doctores.Rows[0];
                TxtIdDoc.Text = info["ID_DOCTOR"].ToString();
                TxtNombre.Text = info["NOMBRES"].ToString();
                TxtApellido.Text = info["APELLIDOS"].ToString();
                CmbEspecial.Text = info["ID_ESPECIALIDAD"].ToString();
                TxtCetificado.Text = info["NUM_COLEGIADO"].ToString();
                TxtTelfono.Text = info["TELEFONO"].ToString();
                TxtCorreo.Text = info["CORREO"].ToString();
                TxtDireccion.Text = info["DIRECCION"].ToString();
                DtFecha.Text = info["FECHA_IN"].ToString();

                BtnGuardar.Enabled = false;
            }
        }

        private void ListarDoctor(string id = "")
        {
            DataTable doctores;
            if (id == "")
            {
                doctores = db.Find($"DOCTORES", "ID_DOCTOR,NOMBRES,APELLIDOS,ID_ESPECIALIDAD,NUM_COLEGIADO,TELEFONO,CORREO,DIRECCION,FECHA_IN,ESTADO");
            }
            else
            {
                string condicion = $"NOMBRES LIKE '%{id}%'";
                doctores = db.Find($"DOCTORES", "ID_DOCTOR,NOMBRES,APELLIDOS,ID_ESPECIALIDAD,NUM_COLEGIADO,TELEFONO,CORREO,DIRECCION,FECHA_IN,ESTADO", condicion);
            }
            DgvData.Rows.Clear();

            string _idcuenta, _nombre, _apellido, _idespecial, _numcol, _telefono, _correo, _direccion, _fecha,_estado;

            foreach (DataRow doctor in doctores.Rows)
            {
                _idcuenta = doctor["ID_DOCTOR"].ToString();
                _nombre = doctor["NOMBRES"].ToString();
                _apellido = doctor["APELLIDOS"].ToString();
                _idespecial =doctor["ID_ESPECIALIDAD"].ToString();
                _numcol = doctor["NUM_COLEGIADO"].ToString();
                _telefono = doctor["TELEFONO"].ToString();
                _correo = doctor["CORREO"].ToString();
                _direccion = doctor["DIRECCION"].ToString();
                _fecha = doctor["FECHA_IN"].ToString();
                _estado = doctor["ESTADO"].ToString();


                DgvData.Rows.Add(_idcuenta, _nombre, _apellido, _idespecial, _numcol, _telefono, _correo, _direccion, _fecha,_estado);
            }
            doctores.Dispose();
        }

    }
}
