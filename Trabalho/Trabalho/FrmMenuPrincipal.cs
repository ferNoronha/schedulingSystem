using Relatorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Trabalho.Model;
using Trabalho.Repository.Interface;
using Trabalho.View;

namespace Trabalho
{
    public partial class FrmMenuPrincipal : Form
    {
        public IAgendamentoRepository MySqlAgendamentoRepository { get; }
        public IMedicoRepository MySqlMedicoRepository { get; }
        public FrmMenuPrincipal(IAgendamentoRepository AgendamentoRepositor, IMedicoRepository medicoRepositor)
        {
            MySqlAgendamentoRepository = AgendamentoRepositor;
            MySqlMedicoRepository = medicoRepositor;
            InitializeComponent();
            InicializarCombos();
        }

        private void button1_Click(object sender, EventArgs e){}
        public void InicializarCombos()
        {
            List<Medico> listamed = new List<Medico>();
            listamed = MySqlMedicoRepository.GetAll().ToList();
            CbbMedico.DataSource = listamed;
            CbbMedico.DisplayMember = "nome";
            CbbMedico.ValueMember = "id";
        }

        private void MstConvenio_Click(object sender, EventArgs e)
        {
            var f = Dependencias.Container.GetInstance<FrmCadastroConvenio>();
            f.Show();
        }

        private void MstCidade_Click(object sender, EventArgs e)
        {
            var f = Dependencias.Container.GetInstance<FrmCadastroCidade>();
            f.Show();
        }

        private void exameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = Dependencias.Container.GetInstance<FrmCadasExame>();
            f.Show();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = Dependencias.Container.GetInstance<FrmCadastroPaciente>();
            f.Show();
        }
        
        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = Dependencias.Container.GetInstance<FrmCadastroAgendamento>();
            f.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            Medico med = new Medico();
            med = CbbMedico.SelectedItem as Medico;
            DateTime data = dtpData.Value;
            Agendamento agendamento = new Agendamento();
            agendamento.dataagenda = data.Date;
            agendamento.Medico = med;
            List<Agendamento> lista = new List<Agendamento>();
            lista = MySqlAgendamentoRepository.GetAgendamento(agendamento).ToList();
            DgvAgendamento.DataSource = lista;
            if (lista.Count == 0)
            {
                MessageBox.Show("Nome não encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void convênioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rep = Dependencias.Container.GetInstance<IConvenioRepository>();
            var convenios = rep.GetAll().ToList();
            var f = new FrmVisualizadorDeRelatorio("Trabalho.Report.RelConvenio.rdlc",
                LocalRelatorio.EmbeddedResource);
            f.AddDataSource(convenios, "DSconvenio");
            f.Show();
        }

        private void exameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var rep = Dependencias.Container.GetInstance<IExameRepository>();
            var exames = rep.GetAll().ToList();
            var f = new FrmVisualizadorDeRelatorio("Trabalho.Report.RelExame.rdlc",
                LocalRelatorio.EmbeddedResource);
            f.AddDataSource(exames, "DSExame");
            f.Show();
        }

        private void pacienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = Dependencias.Container.GetInstance<FrmRelatoriodeAgendamento>();
            f.Show();


        }

        private void agendamento_Click(object sender, EventArgs e)
        {
            Medico med = new Medico();
            med = CbbMedico.SelectedItem as Medico;
            DateTime data = dtpData.Value;
            Agendamento agendamento = new Agendamento();
            agendamento.dataagenda = data.Date;
            agendamento.Medico = med;
            List<Agendamento> lista = new List<Agendamento>();
            lista = MySqlAgendamentoRepository.GetAgendamento(agendamento).ToList();
            //DgvAgendamento.DataSource = lista;
            var agendamen = lista;
            var f = new FrmVisualizadorDeRelatorio("Trabalho.Report.RelAgendamento.rdlc",
                LocalRelatorio.EmbeddedResource);
            f.AddDataSource(lista, "DSAgendamento");
            f.Show();

        }

        private void cadastroMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = Dependencias.Container.GetInstance<FrmCadastroMedico>();
            f.Show();
        }

        private void cadastroMedicoHorárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = Dependencias.Container.GetInstance<FrmCadastroMedicoHorario>();
            f.Show();
        }
    }
}
