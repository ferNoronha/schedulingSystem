using ProjAgendamento.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho.Repository.Interface;
using Trabalho.Model;

namespace Trabalho.View
{
    public partial class FrmCadasExame : Form
    {
        public IExameRepository MySqlExameRepository { get; }
        public FrmCadasExame(IExameRepository mySqlExameRepository)
        {
            MySqlExameRepository = mySqlExameRepository;
            InitializeComponent();
            HabilitarControles();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            var f = new FrmConsExame(MySqlExameRepository);
            if (f.ShowDialog() == DialogResult.OK)
            {
                ID_exame.Text = f.Exame.Id.ToString();
                Descricao_exame.Text = f.Exame.Descricao.ToString();
                Quantidade_exame.Text = f.Exame.QtdeUnidade.ToString();
                HabilitarControles(visualizando: true);

                
            }
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                Exame Exame= new Exame();
                int id;
                int.TryParse(ID_exame.Text, out id);
                Exame.Id = id;
                Exame.Descricao = Descricao_exame.Text;
                Exame.QtdeUnidade = Convert.ToInt32(Quantidade_exame.Text);
                MySqlExameRepository.Gravar(Exame);
                MessageBox.Show("Gravado com sucesso");
                HabilitarControles();
                Descricao_exame.Text = "";
                Quantidade_exame.Text = "";
                ID_exame.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar exame: " + ex.ToString());
            }
        }

        public void HabilitarControles(bool editando = false, bool visualizando = false)
        {
            ID_exame.Enabled = !editando && !visualizando;

            Descricao_exame.Enabled = editando;
            Quantidade_exame.Enabled = editando;
            BtnNovo.Enabled = !editando || visualizando;
            BtnGravar.Enabled = editando;
            BtnExcluir.Enabled = visualizando;
            BtnConsultar.Enabled = !editando || visualizando;
            BtnAlterar.Enabled = visualizando;

            if (editando)
            {
                Descricao_exame.Focus();
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

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Exame Exame = new Exame();
                Exame.Id = Convert.ToInt32(ID_exame.Text);
                MySqlExameRepository.Excluir(Exame);
                MessageBox.Show("Excluido com sucesso");
                HabilitarControles();
                Descricao_exame.Text = "";
                Quantidade_exame.Text = "";
                ID_exame.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir exame: " + ex.ToString());
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarControles();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            HabilitarControles(editando: true);
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            HabilitarControles(editando: true);
        }
    }
}
