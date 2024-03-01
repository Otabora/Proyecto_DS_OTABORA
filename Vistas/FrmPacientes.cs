using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DS_OTABORA.Vistas
{
    public partial class FrmPacientes : Form
    {
        string codigo_pa ,nombre, apellido, identidad, fechanac, direccion, sexo, telefono, correo, estadocivil, estado;


        private void DgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            ListarPacientes(TxtBuscar.Text.Trim());
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
             
        }

        private void TapListpaciente_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //BTN NUEVO
            tabControl1.TabPages.Remove(TapListpaciente);
            tabControl1.TabPages.Add(TapLisAgregar);
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            SetValues();
            string columnas = "NOMBRE,APELLIDO,IDENTIDAD,FECHA_NAC,DIRECCION,SEXO,TELEFONO,CORREO,ESTADO_CIVIL";
            string valores = $"'{nombre}','{apellido}','{identidad}','{fechanac}','{direccion}','{sexo}','{telefono}','{correo}','{estadocivil}'";

            if (db.Save("PACIENTES", columnas, valores))
            {
                h.Advertencia("El Registro se Guardo Con Exito!!");
                ClearForm();
                TxtNombre.Focus();

            }
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            string smg = "Desea Actualizar los datos del Paciente";
            if (h.Question(smg) == true)
            {
                SetValues();
                string actualizar = $"NOMBRE='{nombre}',APELLIDO='{apellido}',IDENTIDAD='{identidad}',FECHA_NAC='{fechanac}',DIRECCION='{direccion}',SEXO='{sexo}',TELEFONO='{telefono}',CORREO='{correo}',ESTADO_CIVIL='{estadocivil}',ESTADO='{estado}'";
                string condicion = $"CODIGO_PA='{codigo_pa}'";

                if (db.Update("PACIENTES", actualizar, condicion) > 0)
                {
                    ClearForm();
                    h.Confirmar("lOS DATOS SE ACTUALIZARON CON EXITO");
                }
            }
            tabControl1.TabPages.Remove(TapLisAgregar);
            tabControl1.TabPages.Add(TapListpaciente);
            BtnEditarpa.Enabled = false;
            BtnEstadopa.Enabled = false;
            ListarPacientes();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (h.Confirmar("Desea Cancelar el registro") == true)
            {
                ClearForm();
                tabControl1.TabPages.Remove(TapLisAgregar);
                tabControl1.TabPages.Add(TapListpaciente);
            }
        }

        private void DgvData_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            estado = DgvData.CurrentRow.Cells[10].Value.ToString();
            codigo_pa = DgvData.CurrentRow.Cells[0].Value.ToString();
            BtnEditarpa.Enabled = true;
            BtnEstadopa.Enabled = true;
        }

        private void BtnEditarpa_Click(object sender, EventArgs e)
        {
            
            if (DgvData.Rows.Count > 0)
            {
                tabControl1.TabPages.Add(TapLisAgregar);
                tabControl1.TabPages.Remove(TapListpaciente);
                string _paciente = DgvData.CurrentRow.Cells[0].Value.ToString();
                GetInfoPacientes(_paciente);

            }
        }

        private void BtnEstadopa_Click(object sender, EventArgs e)
        {
            if (estado == "ACTIVO")
            {
                if (h.Question("Desea Poner el Paciente en Inactivo?") == true)
                {
                    db.Update("PACIENTES","ESTADO = 'INACTIVO'","CODIGO_PA = '"+codigo_pa+"'");
                    DgvData.Rows.Clear();
                    ListarPacientes();
                    MessageBox.Show("El estado se a Cambiado con Exito!!");

                }
            }

            if (estado == "INACTIVO")
            {
                if (h.Question("Desea Poner el Paciente en Activo?") == true)
                {
                    db.Update("PACIENTES", "ESTADO = 'ACTIVO'", "CODIGO_PA = '" + codigo_pa + "'");
                    DgvData.Rows.Clear();
                    ListarPacientes();
                    MessageBox.Show("El estado se a Cambiado con Exito!!");
                }
            }
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            Reportes.Pacientes.FrmRptGralPacientes rptgpaciente = new Reportes.Pacientes.FrmRptGralPacientes();
            rptgpaciente.Show();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
           
        }

        Clases.Helpers h = new Clases.Helpers();
        Clases.DB db = new Clases.DB();
        public FrmPacientes()
        {
            InitializeComponent();
        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            BtnEditarpa.Enabled = false;
            BtnEstadopa.Enabled = false;
            tabControl1.TabPages.Remove(TapLisAgregar);
            ListarPacientes();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void SetValues()
        {
            codigo_pa = Txtcodigo.Text;
            nombre = TxtNombre.Text;
            apellido= TxtApellido.Text;
            identidad = TxtIdedntidad.Text;
            fechanac = DtFechanac.Value.ToString();
            direccion = TxtDireccion.Text;
            sexo = CmbSexo.Text;
            telefono = TxtTelefono.Text;
            correo = TxtCorreo.Text;
            estadocivil = CmbEstadoC.Text;
            
         
        }

        private void ClearForm()
        {
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtIdedntidad.Clear();
            TxtDireccion.Clear();
            CmbSexo.SelectedIndex = 0;
            TxtTelefono.Clear();
            TxtCorreo.Clear();
            CmbEstadoC.SelectedIndex = 0;
            
        }
        private void GetInfoPacientes(string cod_paciente)
        {
            DataTable pacientes = db.Find("PACIENTES", "*", $"CODIGO_PA='{cod_paciente}'");
            if (pacientes.Rows.Count > 0)
            {
                DataRow info = pacientes.Rows[0];
                Txtcodigo.Text = info["CODIGO_PA"].ToString();
                TxtNombre.Text = info["NOMBRE"].ToString();
                TxtApellido.Text = info["APELLIDO"].ToString();
                TxtIdedntidad.Text = info["IDENTIDAD"].ToString();
                DtFechanac.Text = info["FECHA_NAC"].ToString();
                TxtDireccion.Text = info["DIRECCION"].ToString();
                CmbSexo.Text = info["SEXO"].ToString();
                TxtTelefono.Text = info["TELEFONO"].ToString();
                TxtCorreo.Text = info["CORREO"].ToString();
                CmbEstadoC.Text = info["ESTADO_CIVIL"].ToString();
                
                BtnGuardar.Enabled = false;

            }
        }
        //metodo ap
        private void ListarPacientes(string codigo_pa= "")
        {
            DataTable pacientes;
            if (codigo_pa == "")
            {
                pacientes = db.Find($"PACIENTES", "CODIGO_PA,NOMBRE, APELLIDO,IDENTIDAD,FECHA_NAC,DIRECCION,SEXO,TELEFONO,CORREO,ESTADO_CIVIL,ESTADO");
            }
            else
            {
                string condicion = $"NOMBRE LIKE '%{codigo_pa}%'";
                pacientes = db.Find($"PACIENTES", "CODIGO_PA,NOMBRE, APELLIDO,IDENTIDAD,FECHA_NAC,DIRECCION,SEXO,TELEFONO,CORREO,ESTADO_CIVIL,ESTADO", condicion);
            }
            
            DgvData.Rows.Clear();

            string  _codigo,_nombre, _apellido,_identidad,_fecha_nac,_direccion,_sexo,_telefono,_correo,_estadocivil,_estado;

            foreach (DataRow paciente in pacientes.Rows)
            {
                _codigo = paciente["CODIGO_PA"].ToString();
                _nombre = paciente["NOMBRE"].ToString();
                _apellido = paciente["APELLIDO"].ToString();
                _identidad = paciente["IDENTIDAD"].ToString();
                _fecha_nac = paciente["FECHA_NAC"].ToString();
                _direccion = paciente["DIRECCION"].ToString();
                _sexo = paciente["SEXO"].ToString();
                _telefono = paciente["TELEFONO"].ToString();
                _correo = paciente["CORREO"].ToString();
                _estadocivil = paciente["ESTADO_CIVIL"].ToString();
                _estado = paciente["ESTADO"].ToString();

                DgvData.Rows.Add(_codigo,_nombre, _apellido, _identidad,_fecha_nac,_direccion,_sexo,_telefono,_correo,_estadocivil,_estado) ; 
            }
            pacientes.Dispose();
        }
    }
}
