namespace Trabalho.View
{
    partial class FrmCadastroMedicoHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroMedicoHorario));
            this.Id_medho = new System.Windows.Forms.TextBox();
            this.CbbMedico = new System.Windows.Forms.ComboBox();
            this.DtaInicial = new System.Windows.Forms.DateTimePicker();
            this.DtaFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.HraFinal = new System.Windows.Forms.DateTimePicker();
            this.Chatende = new System.Windows.Forms.CheckBox();
            this.Observacao = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HraInicial = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Id_medho
            // 
            this.Id_medho.Location = new System.Drawing.Point(47, 48);
            this.Id_medho.Name = "Id_medho";
            this.Id_medho.Size = new System.Drawing.Size(70, 20);
            this.Id_medho.TabIndex = 0;
            // 
            // CbbMedico
            // 
            this.CbbMedico.FormattingEnabled = true;
            this.CbbMedico.Location = new System.Drawing.Point(47, 119);
            this.CbbMedico.Name = "CbbMedico";
            this.CbbMedico.Size = new System.Drawing.Size(230, 21);
            this.CbbMedico.TabIndex = 5;
            // 
            // DtaInicial
            // 
            this.DtaInicial.Location = new System.Drawing.Point(358, 48);
            this.DtaInicial.Name = "DtaInicial";
            this.DtaInicial.Size = new System.Drawing.Size(260, 20);
            this.DtaInicial.TabIndex = 6;
            // 
            // DtaFinal
            // 
            this.DtaFinal.Location = new System.Drawing.Point(358, 120);
            this.DtaFinal.Name = "DtaFinal";
            this.DtaFinal.Size = new System.Drawing.Size(260, 20);
            this.DtaFinal.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hora Inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date de Inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Médico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date de Término";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(663, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hora Término";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(641, 405);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(99, 23);
            this.BtnCancelar.TabIndex = 47;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(515, 405);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(98, 23);
            this.BtnNovo.TabIndex = 46;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(281, 405);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(95, 23);
            this.BtnAlterar.TabIndex = 44;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(169, 405);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(92, 23);
            this.BtnConsultar.TabIndex = 45;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(395, 405);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(93, 23);
            this.BtnExcluir.TabIndex = 43;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(49, 405);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(91, 23);
            this.BtnGravar.TabIndex = 42;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // HraFinal
            // 
            this.HraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HraFinal.Location = new System.Drawing.Point(666, 120);
            this.HraFinal.Name = "HraFinal";
            this.HraFinal.Size = new System.Drawing.Size(94, 20);
            this.HraFinal.TabIndex = 49;
            // 
            // Chatende
            // 
            this.Chatende.AutoSize = true;
            this.Chatende.Location = new System.Drawing.Point(169, 48);
            this.Chatende.Name = "Chatende";
            this.Chatende.Size = new System.Drawing.Size(60, 17);
            this.Chatende.TabIndex = 50;
            this.Chatende.Text = "Atende";
            this.Chatende.UseVisualStyleBackColor = true;
            // 
            // Observacao
            // 
            this.Observacao.Location = new System.Drawing.Point(47, 237);
            this.Observacao.Name = "Observacao";
            this.Observacao.Size = new System.Drawing.Size(713, 96);
            this.Observacao.TabIndex = 51;
            this.Observacao.Text = "";
            this.Observacao.TextChanged += new System.EventHandler(this.Observacao_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Observação";
            // 
            // HraInicial
            // 
            this.HraInicial.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HraInicial.Location = new System.Drawing.Point(666, 48);
            this.HraInicial.Name = "HraInicial";
            this.HraInicial.Size = new System.Drawing.Size(94, 20);
            this.HraInicial.TabIndex = 48;
            // 
            // FrmCadastroMedicoHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Observacao);
            this.Controls.Add(this.Chatende);
            this.Controls.Add(this.HraFinal);
            this.Controls.Add(this.HraInicial);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtaFinal);
            this.Controls.Add(this.DtaInicial);
            this.Controls.Add(this.CbbMedico);
            this.Controls.Add(this.Id_medho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroMedicoHorario";
            this.Text = "FrmMedicoHorario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Id_medho;
        private System.Windows.Forms.ComboBox CbbMedico;
        private System.Windows.Forms.DateTimePicker DtaInicial;
        private System.Windows.Forms.DateTimePicker DtaFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.DateTimePicker HraFinal;
        private System.Windows.Forms.CheckBox Chatende;
        private System.Windows.Forms.RichTextBox Observacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker HraInicial;
    }
}