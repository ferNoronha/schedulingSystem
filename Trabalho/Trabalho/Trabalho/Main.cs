using Relatorio;
using System;
using System.Linq;
using System.Windows.Forms;
using Trabalho.Model;
using Trabalho.Repository.Interface;
using Trabalho.View;

namespace Trabalho
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        

        private void MstMedico_Click(object sender, EventArgs e)
        {
            var f = Dependencias.Container.GetInstance<FrmCadastroMedico>();
            f.Show();
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
            var f = Dependencias.Container.GetInstance<FrmCadastroExame>();
            f.Show();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = Dependencias.Container.GetInstance<FrmCadastroPaciente>();
            f.Show();
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rep = Dependencias.Container.GetInstance<IConvenioRepository>();
            var convenios = rep.GetAll().ToList();
            var f = new FrmVisualizadorDeRelatorio("Trabalho.Report.RelConvenio.rdlc",
                LocalRelatorio.EmbeddedResource);
            f.AddDataSource(convenios, "DSconvenio");
            f.Show();
        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = Dependencias.Container.GetInstance<FrmCadastroAgendamento>();
            f.Show();
        }
    }
}
