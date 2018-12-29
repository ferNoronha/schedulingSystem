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
    public partial class FrmConsPaciente : Form
    {
        public IPacienteRepository MySqlPacienteRepository { get; }
        public FrmConsPaciente(IPacienteRepository mySqlPacienteRepository)
        {
             MySqlPacienteRepository = mySqlPacienteRepository;
            InitializeComponent();
        }
        public Paciente Paciente { get; set; }
        
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {

            List<Paciente> lista = new List<Paciente>();
            lista=MySqlPacienteRepository.GetByNome(TxtNome.Text).ToList();
            DgvPacientes.DataSource = lista;
            if (lista.Count == 0)
            {
                MessageBox.Show("Nome não encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            Paciente = DgvPacientes.CurrentRow?.DataBoundItem as Paciente;
            if (Paciente != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
