namespace Trabalho.View
{
    partial class FrmCadastroMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroMedico));
            this.CbbConvenio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nome_medico = new System.Windows.Forms.TextBox();
            this.CRM_medico = new System.Windows.Forms.TextBox();
            this.Fone1_medico = new System.Windows.Forms.TextBox();
            this.Fone2_medico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.ID_medico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnCadastrarConvenio = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.DgvConvenio = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConvenio)).BeginInit();
            this.SuspendLayout();
            // 
            // CbbConvenio
            // 
            this.CbbConvenio.FormattingEnabled = true;
            this.CbbConvenio.Location = new System.Drawing.Point(91, 231);
            this.CbbConvenio.Name = "CbbConvenio";
            this.CbbConvenio.Size = new System.Drawing.Size(121, 21);
            this.CbbConvenio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fone 1";
            // 
            // Nome_medico
            // 
            this.Nome_medico.Location = new System.Drawing.Point(51, 87);
            this.Nome_medico.Name = "Nome_medico";
            this.Nome_medico.Size = new System.Drawing.Size(335, 20);
            this.Nome_medico.TabIndex = 2;
            this.Nome_medico.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CRM_medico
            // 
            this.CRM_medico.Location = new System.Drawing.Point(51, 146);
            this.CRM_medico.Name = "CRM_medico";
            this.CRM_medico.Size = new System.Drawing.Size(155, 20);
            this.CRM_medico.TabIndex = 3;
            // 
            // Fone1_medico
            // 
            this.Fone1_medico.Location = new System.Drawing.Point(573, 27);
            this.Fone1_medico.Name = "Fone1_medico";
            this.Fone1_medico.Size = new System.Drawing.Size(186, 20);
            this.Fone1_medico.TabIndex = 4;
            // 
            // Fone2_medico
            // 
            this.Fone2_medico.Location = new System.Drawing.Point(573, 87);
            this.Fone2_medico.Name = "Fone2_medico";
            this.Fone2_medico.Size = new System.Drawing.Size(186, 20);
            this.Fone2_medico.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fone 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Convênio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CRM";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(674, 436);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(99, 23);
            this.BtnCancelar.TabIndex = 29;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(548, 436);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(98, 23);
            this.BtnNovo.TabIndex = 28;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(314, 436);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(95, 23);
            this.BtnAlterar.TabIndex = 26;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(202, 436);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(92, 23);
            this.BtnConsultar.TabIndex = 27;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(428, 436);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(93, 23);
            this.BtnExcluir.TabIndex = 25;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(82, 436);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(91, 23);
            this.BtnGravar.TabIndex = 24;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // ID_medico
            // 
            this.ID_medico.Location = new System.Drawing.Point(51, 27);
            this.ID_medico.Name = "ID_medico";
            this.ID_medico.Size = new System.Drawing.Size(79, 20);
            this.ID_medico.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "ID";
            // 
            // BtnCadastrarConvenio
            // 
            this.BtnCadastrarConvenio.Location = new System.Drawing.Point(269, 229);
            this.BtnCadastrarConvenio.Name = "BtnCadastrarConvenio";
            this.BtnCadastrarConvenio.Size = new System.Drawing.Size(156, 23);
            this.BtnCadastrarConvenio.TabIndex = 14;
            this.BtnCadastrarConvenio.Text = "Cadastrar Convênio";
            this.BtnCadastrarConvenio.UseVisualStyleBackColor = true;
            this.BtnCadastrarConvenio.Click += new System.EventHandler(this.BtnCadastrarConvenio_Click);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(573, 229);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(93, 23);
            this.BtnAdicionar.TabIndex = 70;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(693, 229);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(98, 23);
            this.btnRemover.TabIndex = 69;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // DgvConvenio
            // 
            this.DgvConvenio.AllowUserToAddRows = false;
            this.DgvConvenio.AllowUserToDeleteRows = false;
            this.DgvConvenio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConvenio.Location = new System.Drawing.Point(51, 269);
            this.DgvConvenio.Name = "DgvConvenio";
            this.DgvConvenio.ReadOnly = true;
            this.DgvConvenio.Size = new System.Drawing.Size(802, 103);
            this.DgvConvenio.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(805, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "_________________________________________________________________________________" +
    "____________________________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(805, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "_________________________________________________________________________________" +
    "____________________________________________________";
            // 
            // FrmCadastroMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 491);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.DgvConvenio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ID_medico);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.BtnCadastrarConvenio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fone2_medico);
            this.Controls.Add(this.Fone1_medico);
            this.Controls.Add(this.CRM_medico);
            this.Controls.Add(this.Nome_medico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbbConvenio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroMedico";
            this.Text = "FrmCadastroMedico";
            this.Load += new System.EventHandler(this.FrmCadastroMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvConvenio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbbConvenio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nome_medico;
        private System.Windows.Forms.TextBox CRM_medico;
        private System.Windows.Forms.TextBox Fone1_medico;
        private System.Windows.Forms.TextBox Fone2_medico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.TextBox ID_medico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnCadastrarConvenio;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView DgvConvenio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}