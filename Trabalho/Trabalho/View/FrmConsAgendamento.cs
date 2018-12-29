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
    public partial class FrmConsAgendamento : Form
    {
        IAgendamentoRepository MySqlAgendamentoRepository { get; }
        public Agendamento Agendamento { get; set; }
        public FrmConsAgendamento(IAgendamentoRepository mysqlAgendamentoRepository)
        {
            InitializeComponent();
            MySqlAgendamentoRepository = mysqlAgendamentoRepository;
        }
      
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            List<Agendamento> lista = new List<Agendamento>();
            Agendamento ag = new Agendamento();
            ag.dataagenda = DtpDataAgendamento.Value;
            lista = MySqlAgendamentoRepository.GetByData(ag.dataagenda).ToList();
            DgvAgendamentos.DataSource = lista;
            if (lista.Count == 0)
            {
                MessageBox.Show("Nome não encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            Agendamento = DgvAgendamentos.CurrentRow?.DataBoundItem as Agendamento;
            if (Agendamento != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }

        }
    }
}
