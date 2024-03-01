namespace Proyecto_DS_OTABORA.Reportes.PreClinica
{
    partial class FrmReporteGnralPreClinica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CrvReporteGeneral = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrvReporteGeneral
            // 
            this.CrvReporteGeneral.ActiveViewIndex = -1;
            this.CrvReporteGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvReporteGeneral.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrvReporteGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrvReporteGeneral.Location = new System.Drawing.Point(0, 0);
            this.CrvReporteGeneral.Name = "CrvReporteGeneral";
            this.CrvReporteGeneral.Size = new System.Drawing.Size(800, 450);
            this.CrvReporteGeneral.TabIndex = 0;
            this.CrvReporteGeneral.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.CrvReporteGeneral.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // FrmReporteGnralPreClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CrvReporteGeneral);
            this.Name = "FrmReporteGnralPreClinica";
            this.Text = "FrmReporteGnralPreClinica";
            this.Load += new System.EventHandler(this.FrmReporteGnralPreClinica_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvReporteGeneral;
    }
}