using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho.Model;
using Trabalho.Repository.Interface;

namespace Trabalho.View
{
    public partial class FrmCadastroCidade : Form
    {
        public ICidadeRepository MySqlCidadeRepository { get; }
        public FrmCadastroCidade(ICidadeRepository mySqlCidadeRepository)
        {
            InitializeComponent();
            HabilitarControles();
            MySqlCidadeRepository = mySqlCidadeRepository;
        }
        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                Cidade Cidade = new Cidade();
                Cidade.Id = Convert.ToInt32(ID_cidade.Text);
                Cidade.Nome = Nome_Cidade.Text;
                Cidade.Uf = Estado_Cidade.Text;
                MySqlCidadeRepository.Gravar(Cidade);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cidade: " + ex.ToString());
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Cidade Cidade = new Cidade();
                Cidade.Id = Convert.ToInt32(ID_cidade.Text);
                Cidade.Nome = Nome_Cidade.Text;
                Cidade.Uf = Estado_Cidade.Text;
                MySqlCidadeRepository.Excluir(Cidade);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao excluir cidade: " + ex.ToString());
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {

        }
        public void HabilitarControles(bool editando = false, bool visualizando = false)
        {
            ID_cidade.Enabled = !editando && !visualizando;

            Nome_Cidade.Enabled = editando;
            Estado_Cidade.Enabled = editando;
            BtnNovo.Enabled = !editando || visualizando;
            BtnGravar.Enabled = editando;
            BtnExcluir.Enabled = visualizando;
            BtnConsultar.Enabled = !editando || visualizando;
            BtnAlterar.Enabled = visualizando;

            if (editando)
            {
                Nome_Cidade.Focus();
            }
            else
            {
                if (visualizando)
                {
                    BtnAlterar.Focus();
                }
                else
                {
                    BtnNovo.Focus();
                }
            }

        }

    }
}
