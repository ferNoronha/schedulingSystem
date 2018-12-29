namespace Trabalho
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MstMedico = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroMedicoHorárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MstConvenio = new System.Windows.Forms.ToolStripMenuItem();
            this.MstCidade = new System.Windows.Forms.ToolStripMenuItem();
            this.exameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convênioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSelecionar = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CbbMedico = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvAgendamento = new System.Windows.Forms.DataGridView();
            this.agendamento = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAgendamento)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MstMedico,
            this.MstConvenio,
            this.MstCidade,
            this.exameToolStripMenuItem,
            this.pacienteToolStripMenuItem,
            this.agendamentoToolStripMenuItem,
            this.relatoriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MstMedico
            // 
            this.MstMedico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroMedicoToolStripMenuItem,
            this.cadastroMedicoHorárioToolStripMenuItem});
            this.MstMedico.Name = "MstMedico";
            this.MstMedico.Size = new System.Drawing.Size(59, 20);
            this.MstMedico.Text = "Medico";
            // 
            // cadastroMedicoToolStripMenuItem
            // 
            this.cadastroMedicoToolStripMenuItem.Name = "cadastroMedicoToolStripMenuItem";
            this.cadastroMedicoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cadastroMedicoToolStripMenuItem.Text = "Cadastro Medico";
            this.cadastroMedicoToolStripMenuItem.Click += new System.EventHandler(this.cadastroMedicoToolStripMenuItem_Click);
            // 
            // cadastroMedicoHorárioToolStripMenuItem
            // 
            this.cadastroMedicoHorárioToolStripMenuItem.Name = "cadastroMedicoHorárioToolStripMenuItem";
            this.cadastroMedicoHorárioToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cadastroMedicoHorárioToolStripMenuItem.Text = "Cadastro Medico Horário";
            this.cadastroMedicoHorárioToolStripMenuItem.Click += new System.EventHandler(this.cadastroMedicoHorárioToolStripMenuItem_Click);
            // 
            // MstConvenio
            // 
            this.MstConvenio.Name = "MstConvenio";
            this.MstConvenio.Size = new System.Drawing.Size(70, 20);
            this.MstConvenio.Text = "Convenio";
            this.MstConvenio.Click += new System.EventHandler(this.MstConvenio_Click);
            // 
            // MstCidade
            // 
            this.MstCidade.Name = "MstCidade";
            this.MstCidade.Size = new System.Drawing.Size(56, 20);
            this.MstCidade.Text = "Cidade";
            this.MstCidade.Click += new System.EventHandler(this.MstCidade_Click);
            // 
            // exameToolStripMenuItem
            // 
            this.exameToolStripMenuItem.Name = "exameToolStripMenuItem";
            this.exameToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exameToolStripMenuItem.Text = "Exame";
            this.exameToolStripMenuItem.Click += new System.EventHandler(this.exameToolStripMenuItem_Click);
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.pacienteToolStripMenuItem.Text = "Paciente";
            this.pacienteToolStripMenuItem.Click += new System.EventHandler(this.pacienteToolStripMenuItem_Click);
            // 
            // agendamentoToolStripMenuItem
            // 
            this.agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
            this.agendamentoToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.agendamentoToolStripMenuItem.Text = "Agendamento";
            this.agendamentoToolStripMenuItem.Click += new System.EventHandler(this.agendamentoToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convênioToolStripMenuItem,
            this.exameToolStripMenuItem1,
            this.pacienteToolStripMenuItem1});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // convênioToolStripMenuItem
            // 
            this.convênioToolStripMenuItem.Name = "convênioToolStripMenuItem";
            this.convênioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.convênioToolStripMenuItem.Text = "Convênio";
            this.convênioToolStripMenuItem.Click += new System.EventHandler(this.convênioToolStripMenuItem_Click);
            // 
            // exameToolStripMenuItem1
            // 
            this.exameToolStripMenuItem1.Name = "exameToolStripMenuItem1";
            this.exameToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exameToolStripMenuItem1.Text = "Exame";
            this.exameToolStripMenuItem1.Click += new System.EventHandler(this.exameToolStripMenuItem1_Click);
            // 
            // pacienteToolStripMenuItem1
            // 
            this.pacienteToolStripMenuItem1.Name = "pacienteToolStripMenuItem1";
            this.pacienteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pacienteToolStripMenuItem1.Text = "Horário de Medicos";
            this.pacienteToolStripMenuItem1.Click += new System.EventHandler(this.pacienteToolStripMenuItem1_Click);
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.Location = new System.Drawing.Point(701, 51);
            this.BtnSelecionar.Name = "BtnSelecionar";
            this.BtnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.BtnSelecionar.TabIndex = 7;
            this.BtnSelecionar.Text = "Selecionar";
            this.BtnSelecionar.UseVisualStyleBackColor = true;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(620, 51);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 6;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // CbbMedico
            // 
            this.CbbMedico.FormattingEnabled = true;
            this.CbbMedico.Location = new System.Drawing.Point(12, 54);
            this.CbbMedico.Name = "CbbMedico";
            this.CbbMedico.Size = new System.Drawing.Size(245, 21);
            this.CbbMedico.TabIndex = 8;
            this.CbbMedico.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(317, 51);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(95, 20);
            this.dtpData.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data";
            // 
            // DgvAgendamento
            // 
            this.DgvAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAgendamento.Location = new System.Drawing.Point(0, 122);
            this.DgvAgendamento.Name = "DgvAgendamento";
            this.DgvAgendamento.Size = new System.Drawing.Size(800, 332);
            this.DgvAgendamento.TabIndex = 11;
            // 
            // agendamento
            // 
            this.agendamento.Location = new System.Drawing.Point(12, 93);
            this.agendamento.Name = "agendamento";
            this.agendamento.Size = new System.Drawing.Size(155, 23);
            this.agendamento.TabIndex = 12;
            this.agendamento.Text = "Relatorio de Agendamento";
            this.agendamento.UseVisualStyleBackColor = true;
            this.agendamento.Click += new System.EventHandler(this.agendamento_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.agendamento);
            this.Controls.Add(this.DgvAgendamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.CbbMedico);
            this.Controls.Add(this.BtnSelecionar);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuPrincipal";
            this.Text = "Agendamento para Clínicas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAgendamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MstMedico;
        private System.Windows.Forms.ToolStripMenuItem MstConvenio;
        private System.Windows.Forms.ToolStripMenuItem MstCidade;
        private System.Windows.Forms.ToolStripMenuItem exameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoToolStripMenuItem;
        private System.Windows.Forms.Button BtnSelecionar;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbbMedico;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvAgendamento;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convênioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem1;
        private System.Windows.Forms.Button agendamento;
        private System.Windows.Forms.ToolStripMenuItem cadastroMedicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroMedicoHorárioToolStripMenuItem;
    }
}

