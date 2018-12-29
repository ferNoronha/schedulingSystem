namespace Trabalho.View
{
    partial class FrmRelatoriodeAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatoriodeAgendamento));
            this.dtainicio = new System.Windows.Forms.DateTimePicker();
            this.DTAFIM = new System.Windows.Forms.DateTimePicker();
            this.HRAFIM = new System.Windows.Forms.DateTimePicker();
            this.HRAINICIO = new System.Windows.Forms.DateTimePicker();
            this.horInicio = new System.Windows.Forms.Label();
            this.DD = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.Label();
            this.horafinal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtainicio
            // 
            this.dtainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtainicio.Location = new System.Drawing.Point(129, 65);
            this.dtainicio.Name = "dtainicio";
            this.dtainicio.Size = new System.Drawing.Size(200, 20);
            this.dtainicio.TabIndex = 0;
            // 
            // DTAFIM
            // 
            this.DTAFIM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTAFIM.Location = new System.Drawing.Point(525, 65);
            this.DTAFIM.Name = "DTAFIM";
            this.DTAFIM.Size = new System.Drawing.Size(200, 20);
            this.DTAFIM.TabIndex = 1;
            // 
            // HRAFIM
            // 
            this.HRAFIM.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HRAFIM.Location = new System.Drawing.Point(525, 137);
            this.HRAFIM.Name = "HRAFIM";
            this.HRAFIM.Size = new System.Drawing.Size(91, 20);
            this.HRAFIM.TabIndex = 2;
            // 
            // HRAINICIO
            // 
            this.HRAINICIO.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HRAINICIO.Location = new System.Drawing.Point(129, 127);
            this.HRAINICIO.Name = "HRAINICIO";
            this.HRAINICIO.Size = new System.Drawing.Size(90, 20);
            this.HRAINICIO.TabIndex = 3;
            // 
            // horInicio
            // 
            this.horInicio.AutoSize = true;
            this.horInicio.Location = new System.Drawing.Point(41, 133);
            this.horInicio.Name = "horInicio";
            this.horInicio.Size = new System.Drawing.Size(82, 13);
            this.horInicio.TabIndex = 6;
            this.horInicio.Text = "Horário de Incio";
            // 
            // DD
            // 
            this.DD.AutoSize = true;
            this.DD.Location = new System.Drawing.Point(50, 71);
            this.DD.Name = "DD";
            this.DD.Size = new System.Drawing.Size(73, 13);
            this.DD.TabIndex = 7;
            this.DD.Text = "Data de Inicio";
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Location = new System.Drawing.Point(446, 72);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(55, 13);
            this.S.TabIndex = 8;
            this.S.Text = "Data Final";
            // 
            // horafinal
            // 
            this.horafinal.AutoSize = true;
            this.horafinal.Location = new System.Drawing.Point(437, 143);
            this.horafinal.Name = "horafinal";
            this.horafinal.Size = new System.Drawing.Size(66, 13);
            this.horafinal.TabIndex = 9;
            this.horafinal.Text = "Horário Final";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "GERAR RELATÓRIO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRelatoriodeAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.horafinal);
            this.Controls.Add(this.S);
            this.Controls.Add(this.DD);
            this.Controls.Add(this.horInicio);
            this.Controls.Add(this.HRAINICIO);
            this.Controls.Add(this.HRAFIM);
            this.Controls.Add(this.DTAFIM);
            this.Controls.Add(this.dtainicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRelatoriodeAgendamento";
            this.Text = "FrmRelatoriodeAgendamento";
            this.Load += new System.EventHandler(this.FrmRelatoriodeAgendamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtainicio;
        private System.Windows.Forms.DateTimePicker DTAFIM;
        private System.Windows.Forms.DateTimePicker HRAFIM;
        private System.Windows.Forms.DateTimePicker HRAINICIO;
        private System.Windows.Forms.Label horInicio;
        private System.Windows.Forms.Label DD;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Label horafinal;
        private System.Windows.Forms.Button button1;
    }
}