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
    public partial class FrmConsConvenio : Form
    {
        public Convenio Convenio { get; set; }
        public IConvenioRepository MySqlConvenioRepository { get; }
        public FrmConsConvenio(IConvenioRepository mySqlConvenioRepository)
        {
            InitializeComponent();
            MySqlConvenioRepository = mySqlConvenioRepository;
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            List<Convenio> lista = new List<Convenio>();
            lista = MySqlConvenioRepository.GetByNome(TxtNome.Text).ToList();
            DgvConvenio.DataSource = lista;
            if (lista.Count == 0)
            {
                MessageBox.Show("Nome não encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            Convenio = DgvConvenio.CurrentRow?.DataBoundItem as Convenio;
            if (Convenio != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
