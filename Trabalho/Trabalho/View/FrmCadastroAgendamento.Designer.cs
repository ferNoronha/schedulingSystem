namespace Trabalho.View
{
    partial class FrmCadastroAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroAgendamento));
            this.ID_Agendamento = new System.Windows.Forms.TextBox();
            this.data_agendamento = new System.Windows.Forms.DateTimePicker();
            this.CbbPaciente = new System.Windows.Forms.ComboBox();
            this.CbbSituacao = new System.Windows.Forms.ComboBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.Paciente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CbbExame = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Qtde = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CbbMedico = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbbConvenio = new System.Windows.Forms.ComboBox();
            this.DgvExames = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.Observacao = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExames)).BeginInit();
            this.SuspendLayout();
            // 
            // ID_Agendamento
            // 
            this.ID_Agendamento.Location = new System.Drawing.Point(28, 30);
            this.ID_Agendamento.Name = "ID_Agendamento";
            this.ID_Agendamento.Size = new System.Drawing.Size(90, 20);
            this.ID_Agendamento.TabIndex = 0;
            // 
            // data_agendamento
            // 
            this.data_agendamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_agendamento.Location = new System.Drawing.Point(575, 31);
            this.data_agendamento.Name = "data_agendamento";
            this.data_agendamento.Size = new System.Drawing.Size(94, 20);
            this.data_agendamento.TabIndex = 2;
            // 
            // CbbPaciente
            // 
            this.CbbPaciente.FormattingEnabled = true;
            this.CbbPaciente.Location = new System.Drawing.Point(28, 88);
            this.CbbPaciente.Name = "CbbPaciente";
            this.CbbPaciente.Size = new System.Drawing.Size(230, 21);
            this.CbbPaciente.TabIndex = 7;
            this.CbbPaciente.SelectedIndexChanged += new System.EventHandler(this.CbbPaciente_SelectedIndexChanged);
            // 
            // CbbSituacao
            // 
            this.CbbSituacao.FormattingEnabled = true;
            this.CbbSituacao.Location = new System.Drawing.Point(575, 88);
            this.CbbSituacao.Name = "CbbSituacao";
            this.CbbSituacao.Size = new System.Drawing.Size(193, 21);
            this.CbbSituacao.TabIndex = 11;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(349, 228);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(79, 20);
            this.Total.TabIndex = 12;
            this.Total.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(34, 14);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 10;
            this.ID.Text = "ID";
            // 
            // Paciente
            // 
            this.Paciente.AutoSize = true;
            this.Paciente.Location = new System.Drawing.Point(34, 72);
            this.Paciente.Name = "Paciente";
            this.Paciente.Size = new System.Drawing.Size(49, 13);
            this.Paciente.TabIndex = 13;
            this.Paciente.Text = "Paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Situação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(583, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Data agenda";
            // 
            // CbbExame
            // 
            this.CbbExame.FormattingEnabled = true;
            this.CbbExame.Location = new System.Drawing.Point(26, 231);
            this.CbbExame.Name = "CbbExame";
            this.CbbExame.Size = new System.Drawing.Size(149, 21);
            this.CbbExame.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Exame";
            // 
            // Qtde
            // 
            this.Qtde.Location = new System.Drawing.Point(234, 231);
            this.Qtde.Name = "Qtde";
            this.Qtde.Size = new System.Drawing.Size(79, 20);
            this.Qtde.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Quantidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Medico";
            // 
            // CbbMedico
            // 
            this.CbbMedico.FormattingEnabled = true;
            this.CbbMedico.Location = new System.Drawing.Point(289, 88);
            this.CbbMedico.Name = "CbbMedico";
            this.CbbMedico.Size = new System.Drawing.Size(230, 21);
            this.CbbMedico.TabIndex = 24;
            this.CbbMedico.SelectedIndexChanged += new System.EventHandler(this.CbbMedico_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Convenio";
            // 
            // CbbConvenio
            // 
            this.CbbConvenio.FormattingEnabled = true;
            this.CbbConvenio.Location = new System.Drawing.Point(289, 30);
            this.CbbConvenio.Name = "CbbConvenio";
            this.CbbConvenio.Size = new System.Drawing.Size(230, 21);
            this.CbbConvenio.TabIndex = 28;
            this.CbbConvenio.SelectedIndexChanged += new System.EventHandler(this.CbbConvenio_SelectedIndexChanged);
            // 
            // DgvExames
            // 
            this.DgvExames.AllowUserToAddRows = false;
            this.DgvExames.AllowUserToDeleteRows = false;
            this.DgvExames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExames.Location = new System.Drawing.Point(24, 268);
            this.DgvExames.Name = "DgvExames";
            this.DgvExames.ReadOnly = true;
            this.DgvExames.Size = new System.Drawing.Size(744, 103);
            this.DgvExames.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(745, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "_________________________________________________________________________________" +
    "__________________________________________";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(642, 404);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(99, 23);
            this.BtnCancelar.TabIndex = 58;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(516, 404);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(98, 23);
            this.BtnNovo.TabIndex = 57;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(282, 404);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(95, 23);
            this.BtnAlterar.TabIndex = 55;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(170, 404);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(92, 23);
            this.BtnConsultar.TabIndex = 56;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(396, 404);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(93, 23);
            this.BtnExcluir.TabIndex = 54;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(50, 404);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(91, 23);
            this.BtnGravar.TabIndex = 53;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(550, 228);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(93, 23);
            this.BtnAdicionar.TabIndex = 60;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(670, 228);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(98, 23);
            this.btnRemover.TabIndex = 59;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // Observacao
            // 
            this.Observacao.Location = new System.Drawing.Point(28, 142);
            this.Observacao.Name = "Observacao";
            this.Observacao.Size = new System.Drawing.Size(740, 67);
            this.Observacao.TabIndex = 61;
            this.Observacao.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Observação";
            // 
            // FrmCadastroAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Observacao);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DgvExames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbbConvenio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CbbMedico);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Qtde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbbExame);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Paciente);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.CbbSituacao);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.CbbPaciente);
            this.Controls.Add(this.data_agendamento);
            this.Controls.Add(this.ID_Agendamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroAgendamento";
            this.Text = "FrmCadastroAgendamento";
            this.Load += new System.EventHandler(this.FrmCadastroAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvExames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_Agendamento;
        private System.Windows.Forms.DateTimePicker data_agendamento;
        private System.Windows.Forms.ComboBox CbbPaciente;
        private System.Windows.Forms.ComboBox CbbSituacao;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Paciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbbExame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Qtde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbbMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbbConvenio;
        private System.Windows.Forms.DataGridView DgvExames;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.RichTextBox Observacao;
        private System.Windows.Forms.Label label3;
    }
}