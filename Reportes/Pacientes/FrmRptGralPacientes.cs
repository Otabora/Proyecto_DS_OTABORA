using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DS_OTABORA.Reportes.Pacientes
{
    public partial class FrmRptGralPacientes : Form
    {
        public FrmRptGralPacientes()
        {
            InitializeComponent();
        }

        private void FrmRptGralPacientes_Load(object sender, EventArgs e)
        {
            Reportes.Pacientes.CRReporteGralPacientes RptGeneralPac = new Reportes.Pacientes.CRReporteGralPacientes();
            RptGeneralPac.SetDatabaseLogon(Clases.Entorno.USER, Clases.Entorno.PWD);

            CrvReporteGeneral.ReportSource = RptGeneralPac;
        }

        private void CrvReporteGeneral_Load(object sender, EventArgs e)
        {

        }
    }
}
