namespace Trabalho.View
{
    partial class FrmConsExame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsExame));
            this.DgvExame = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSelecionar = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.TxtExame = new System.Windows.Forms.TextBox();
            this.exame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExame)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvExame
            // 
            this.DgvExame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvExame.Location = new System.Drawing.Point(0, 70);
            this.DgvExame.Name = "DgvExame";
            this.DgvExame.Size = new System.Drawing.Size(800, 380);
            this.DgvExame.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnSelecionar);
            this.panel1.Controls.Add(this.BtnPesquisar);
            this.panel1.Controls.Add(this.TxtExame);
            this.panel1.Controls.Add(this.exame);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 70);
            this.panel1.TabIndex = 10;
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.Location = new System.Drawing.Point(701, 28);
            this.BtnSelecionar.Name = "BtnSelecionar";
            this.BtnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.BtnSelecionar.TabIndex = 3;
            this.BtnSelecionar.Text = "Selecionar";
            this.BtnSelecionar.UseVisualStyleBackColor = true;
            this.BtnSelecionar.Click += new System.EventHandler(this.BtnSelecionar_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(620, 28);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 2;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // TxtExame
            // 
            this.TxtExame.Location = new System.Drawing.Point(10, 30);
            this.TxtExame.Name = "TxtExame";
            this.TxtExame.Size = new System.Drawing.Size(600, 20);
            this.TxtExame.TabIndex = 1;
            // 
            // exame
            // 
            this.exame.AutoSize = true;
            this.exame.Location = new System.Drawing.Point(10, 15);
            this.exame.Name = "exame";
            this.exame.Size = new System.Drawing.Size(39, 13);
            this.exame.TabIndex = 0;
            this.exame.Text = "Exame";
            // 
            // FrmConsExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvExame);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsExame";
            this.Text = "FrmConsExame";
            ((System.ComponentModel.ISupportInitialize)(this.DgvExame)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvExame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSelecionar;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.TextBox TxtExame;
        private System.Windows.Forms.Label exame;
    }
}