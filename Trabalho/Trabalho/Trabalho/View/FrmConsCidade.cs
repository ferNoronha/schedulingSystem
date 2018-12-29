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
    public partial class FrmConsCidade : Form
    {

        public Cidade Cidade { get; set; }
        public ICidadeRepository MySqlCidadeRepository { get; }
        public FrmConsCidade(ICidadeRepository mySqlCidadeRepository)
        {
            InitializeComponent();
            MySqlCidadeRepository = mySqlCidadeRepository;
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {

            List<Cidade> lista = new List<Cidade>();
            lista = MySqlCidadeRepository.GetByNome(TxtCidade.Text).ToList();
            DgvCidade.DataSource = lista;
            if (lista.Count == 0)
            {
                MessageBox.Show("Cidade não encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            Cidade = DgvCidade.CurrentRow?.DataBoundItem as Cidade;
            if (Cidade != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
