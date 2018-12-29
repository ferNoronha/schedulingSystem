using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho.View
{
    public partial class FrmCadastroExame : Form
    {
        private Button BtnCancelar;
        private Button BtnNovo;
        private Button BtnAlterar;
        private Button BtnConsultar;
        private Button BtnExcluir;
        private Button BtnGravar;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox ID_exame;
        private TextBox Quantidade_exame;
        private TextBox Descricao_exame;

        public FrmCadastroExame()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_exame = new System.Windows.Forms.TextBox();
            this.Quantidade_exame = new System.Windows.Forms.TextBox();
            this.Descricao_exame = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(628, 374);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(99, 23);
            this.BtnCancelar.TabIndex = 53;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(502, 374);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(98, 23);
            this.BtnNovo.TabIndex = 52;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(268, 374);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(95, 23);
            this.BtnAlterar.TabIndex = 50;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(156, 374);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(92, 23);
            this.BtnConsultar.TabIndex = 51;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(382, 374);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(93, 23);
            this.BtnExcluir.TabIndex = 49;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(36, 374);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(91, 23);
            this.BtnGravar.TabIndex = 48;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Descrição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "ID";
            // 
            // ID_exame
            // 
            this.ID_exame.Location = new System.Drawing.Point(29, 69);
            this.ID_exame.Name = "ID_exame";
            this.ID_exame.Size = new System.Drawing.Size(58, 20);
            this.ID_exame.TabIndex = 44;
            // 
            // Quantidade_exame
            // 
            this.Quantidade_exame.Location = new System.Drawing.Point(29, 183);
            this.Quantidade_exame.Name = "Quantidade_exame";
            this.Quantidade_exame.Size = new System.Drawing.Size(100, 20);
            this.Quantidade_exame.TabIndex = 43;
            // 
            // Descricao_exame
            // 
            this.Descricao_exame.Location = new System.Drawing.Point(29, 125);
            this.Descricao_exame.Name = "Descricao_exame";
            this.Descricao_exame.Size = new System.Drawing.Size(313, 20);
            this.Descricao_exame.TabIndex = 42;
            // 
            // FrmCadastroExame
            // 
            this.ClientSize = new System.Drawing.Size(765, 485);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_exame);
            this.Controls.Add(this.Quantidade_exame);
            this.Controls.Add(this.Descricao_exame);
            this.Name = "FrmCadastroExame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
