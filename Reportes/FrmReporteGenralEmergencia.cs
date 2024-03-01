using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_DS_OTABORA.Reportes
{
    public partial class FrmReporteGenralEmergencia : Form
    {
        public FrmReporteGenralEmergencia()
        {
            InitializeComponent();
        }

        private void FrmReporteGenralEmergencia_Load(object sender, EventArgs e)
        {
            Reportes.CRReporteGnralEmergencias RptGeneralPac = new Reportes.CRReporteGnralEmergencias();
            RptGeneralPac.SetDatabaseLogon(Clases.Entorno.USER, Clases.Entorno.PWD);

            CrvReporteGenral.ReportSource = RptGeneralPac;
        }
    }
}
