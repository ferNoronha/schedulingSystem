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
using Relatorio;

namespace Trabalho.View
{
    public partial class FrmRelatoriodeAgendamento : Form
    {
        public FrmRelatoriodeAgendamento()
        {
            InitializeComponent();
        }

        private void FrmRelatoriodeAgendamento_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rep = Dependencias.Container.GetInstance<IMedicoHorarioRepository>();
            var hor = rep.GetAll().ToList();
            var f = new FrmVisualizadorDeRelatorio("Trabalho.Report.RelMedicoHorario.rdlc",
                LocalRelatorio.EmbeddedResource);
            f.AddDataSource(hor, "DSHorarioMedico");
            f.Show();
        }
    }
}
