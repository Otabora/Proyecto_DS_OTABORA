using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DS_OTABORA.Reportes.PreClinica
{
    public partial class FrmReporteGnralPreClinica : Form
    {
        public FrmReporteGnralPreClinica()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Reportes.PreClinica.CRReporteGnralPreClinica RptGeneralPre = new Reportes.PreClinica.CRReporteGnralPreClinica();
            RptGeneralPre.SetDatabaseLogon(Clases.Entorno.USER, Clases.Entorno.PWD);

            CrvReporteGeneral.ReportSource = RptGeneralPre;
        }

        private void FrmReporteGnralPreClinica_Load(object sender, EventArgs e)
        {

        }
    }
}
