using ProjAgendamento.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Trabalho.Model;
using Trabalho.Repository.Interface;

namespace Trabalho.View
{
    public partial class FrmCadastroAgendamento : Form
    {
        public Paciente paciente { get; set; }
        public IPacienteRepository MySqlPacienteRepository { get; }
        public IMedicoRepository MySqlMedicoRepository { get; }
        public IConvenioRepository MySqlConvenioRepository { get; }
        public IExameRepository MySqlExameRepository { get; }
        public FrmCadastroAgendamento(IExameRepository ExameRepositor, IPacienteRepository PacienteRepositor, IMedicoRepository MedicoRepositor, IConvenioRepository ConvenioRepositor)
        {
            MySqlPacienteRepository =  PacienteRepositor;
            MySqlMedicoRepository = MedicoRepositor;
            MySqlConvenioRepository = ConvenioRepositor;
            MySqlExameRepository = ExameRepositor;
            InitializeComponent();
            InicializarCombos();
        }
        private void textBox2_TextChanged(object sender, EventArgs e){}
        private void label9_Click(object sender, EventArgs e){}
        private void BtnGravar_Click(object sender, EventArgs e){}
        public void InicializarCombos()
        {
            List<Paciente> lista = new List<Paciente>();
            List<Medico> listamed = new List<Medico>();
            List<Situacao> situacao = new List<Situacao>();
            List<Convenio> convenio = new List<Convenio>();
            List<Exame> exame = new List<Exame>();
            lista = MySqlPacienteRepository.GetAll().ToList();
            CbbPaciente.DataSource = lista;
            CbbPaciente.DisplayMember = "nome";
            CbbPaciente.ValueMember = "id";

            listamed = MySqlMedicoRepository.GetAll().ToList();
            CbbMedico.DataSource = listamed;
            CbbMedico.DisplayMember = "nome";
            CbbMedico.ValueMember = "id";

            situacao = MySqlPacienteRepository.GetSituacoes().ToList();
            CbbSituacao.DataSource = situacao;
            CbbSituacao.DisplayMember = "descricao";
            CbbSituacao.ValueMember = "id";

            convenio = MySqlConvenioRepository.GetAll().ToList();
            CbbConvenio.DataSource = convenio;
            CbbConvenio.DisplayMember = "nome";
            CbbConvenio.ValueMember = "id";

            exame = MySqlExameRepository.GetAll().ToList();
            CbbExame.DataSource = exame;
            CbbExame.DisplayMember = "descricao";
            CbbExame.ValueMember = "id";

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            /*Produto prod = CombProdutoId.SelectedItem as Produto;
            Cliente cli = CombClienteId.SelectedItem as Cliente;
            Decimal totalgeral;
            decimal aux;
            int qtde = Convert.ToInt32(TxtQuantidade.Text);
            VendaProdutos vend = new VendaProdutos();
            vendas.Add(vend);
            vend.produtoid = prod;
            vend.quantidade = Convert.ToInt32(TxtQuantidade.Text);
            vend.valorunitario = prod.Preco;
            Decimal.TryParse(TotalTxt.Text, out aux);
            vend.valortotal = (prod.Preco * vend.quantidade);
            totalgeral = Convert.ToDecimal(vend.valortotal) + aux;
            TotalTxt.Text = Convert.ToString(totalgeral);
            DgvVendas.DataSource = vendas;*/

        }


        public void CbbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Paciente = CbbPaciente.SelectedItem as Paciente;
            //if (Paciente != null)
            //{
            //    CbbPaciente.SelectedItem = Paciente;
            //}
        }
    }
}
