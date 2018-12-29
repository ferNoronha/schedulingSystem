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
    public partial class FrmConsExame : Form
    {
        public IExameRepository MySqlExameRepository { get; }
        public Exame Exame { get; set; }
        public FrmConsExame(IExameRepository mySqlExameRepository)
        {
            InitializeComponent();
            MySqlExameRepository = mySqlExameRepository;
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            List<Exame> lista = new List<Exame>();
            lista = MySqlExameRepository.GetByNome(TxtExame.Text).ToList();
            DgvExame.DataSource = lista;
            if (lista.Count == 0)
            {
                MessageBox.Show("Nome não encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            Exame = DgvExame.CurrentRow?.DataBoundItem as Exame;
            if (Exame != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
