namespace Relatorio
{
    partial class FrmVisualizadorDeRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisualizadorDeRelatorio));
            this.rpvRelatorio = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvRelatorio
            // 
            this.rpvRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvRelatorio.Location = new System.Drawing.Point(0, 0);
            this.rpvRelatorio.Name = "rpvRelatorio";
            this.rpvRelatorio.ServerReport.BearerToken = null;
            this.rpvRelatorio.Size = new System.Drawing.Size(536, 351);
            this.rpvRelatorio.TabIndex = 0;
            // 
            // FrmVisualizadorDeRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 351);
            this.Controls.Add(this.rpvRelatorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVisualizadorDeRelatorio";
            this.Text = "Visualizador de Relatório";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVisualizarDeRelatorio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvRelatorio;
    }
}