namespace Proyecto_DS_OTABORA.Reportes
{
    partial class FrmReporteGenralEmergencia
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
            this.CrvReporteGenral = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CrvReporteGenral
            // 
            this.CrvReporteGenral.ActiveViewIndex = -1;
            this.CrvReporteGenral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrvReporteGenral.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrvReporteGenral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrvReporteGenral.Location = new System.Drawing.Point(0, 0);
            this.CrvReporteGenral.Name = "CrvReporteGenral";
            this.CrvReporteGenral.Size = new System.Drawing.Size(800, 450);
            this.CrvReporteGenral.TabIndex = 0;
            this.CrvReporteGenral.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmReporteGenralEmergencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CrvReporteGenral);
            this.Name = "FrmReporteGenralEmergencia";
            this.Text = "FrmReporteGenralEmergencia";
            this.Load += new System.EventHandler(this.FrmReporteGenralEmergencia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrvReporteGenral;
    }
}