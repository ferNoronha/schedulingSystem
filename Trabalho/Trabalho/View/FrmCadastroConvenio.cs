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
    public partial class FrmCadastroConvenio : Form
    {
        public IConvenioRepository MySqlConvenioRepository { get; }
        public FrmCadastroConvenio(IConvenioRepository mySqlConvenioRepository)
        {
            InitializeComponent();
            MySqlConvenioRepository = mySqlConvenioRepository;
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Convenio Convenio = new Convenio();
            int id;
            int.TryParse(Convenio_id.Text, out id);
            Convenio.Id = id;
            Convenio.Nome = Nome_convenio.Text;
            Convenio.ValorUnidade = Convert.ToDecimal(Valorconvenio.Text);///verificar como passar o id 0 ou id do convenio a alterar
            MySqlConvenioRepository.Gravar(Convenio);
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Convenio convenio = new Convenio();
            convenio.Id = Convert.ToInt32(Convenio_id.Text);
            MySqlConvenioRepository.Excluir(convenio);
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            var f = new FrmConsConvenio(MySqlConvenioRepository);
            if (f.ShowDialog() == DialogResult.OK)
            {
                Convenio_id.Text = f.Convenio.Id.ToString();
                Nome_convenio.Text = f.Convenio.Nome.ToString();
                Valorconvenio.Text = f.Convenio.ValorUnidade.ToString();

                //HabilitarControles(visualizando: true);


                //terminar de receber parametros;
            }
        }
    }
}
