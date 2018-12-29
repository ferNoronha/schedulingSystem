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
    public partial class FrmConsMedico : Form
    {
        public IMedicoRepository MySqlMedicoRepository { get; }
        public Medico Medico { get; set; }
        public FrmConsMedico(IMedicoRepository mySqlMedicoRepository)
        {
            InitializeComponent();
            MySqlMedicoRepository = mySqlMedicoRepository;
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            List<Medico> lista = new List<Medico>();
            lista = MySqlMedicoRepository.GetByNome(TxtNome.Text).ToList();
            DgvMedico.DataSource = lista;
            if (lista.Count == 0)
            {
                MessageBox.Show("Nome não encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            Medico = DgvMedico.CurrentRow?.DataBoundItem as Medico;
            if (Medico != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
