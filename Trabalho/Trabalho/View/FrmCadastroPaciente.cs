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
    public partial class FrmCadastroPaciente : Form
    {
        public Paciente Paciente { get; private set; }
        public IConvenioRepository MySqlConvenioRepository { get; }
        public ICidadeRepository MySqlCidadeRepository { get; }
        public IPacienteRepository MySqlPacienteRepository { get; }
        public FrmCadastroPaciente(IPacienteRepository  mySqlPacienteRepository, IConvenioRepository mySqlConvenioRepository, ICidadeRepository mySqlCidadeRepository)
        {
            InitializeComponent();
            Inicializar();
            MySqlCidadeRepository = mySqlCidadeRepository;
            MySqlConvenioRepository = mySqlConvenioRepository;
            MySqlPacienteRepository = mySqlPacienteRepository;
            InicializarCombos();
        }
        private void Inicializar()
        {
            Paciente = new Paciente();
            HabilitarControles();
        }
        public void InicializarCombos()
        {
            List<Convenio> convenio = new List<Convenio>();
            convenio = MySqlConvenioRepository.GetAll().ToList();
            CbbConvenio.DataSource = convenio;
            CbbConvenio.DisplayMember = "nome";
            CbbConvenio.ValueMember = "id";

            List<Cidade> cidade = new List<Cidade>();
            cidade = MySqlCidadeRepository.GetAll().ToList();
            CbbCidade.DataSource = cidade;
            CbbCidade.DisplayMember = "nome";
            CbbCidade.ValueMember = "id";
        }
        public void HabilitarControles(bool editando = false, bool visualizando = false)
        {
            ID_Paciente.Enabled = !editando && !visualizando;
            CbbConvenio.Enabled = editando;
            CbbCidade.Enabled = editando;
            Bairro_Paciente.Enabled = editando;
            CEP_Paciente.Enabled = editando;
            Logradouro_Paciente.Enabled = editando;
            DataNascimento_Paciente.Enabled = editando;
            Complemento_Paciente.Enabled = editando;
            Email_Paciente.Enabled = editando;
            Cel1_Paciente.Enabled = editando;
            Cel2_Paciente.Enabled = editando;
            Fonecom_Paciente.Enabled = editando;
            Foneres_Paciente.Enabled = editando;
            Nome_Paciente.Enabled = editando;
            Num_Paciente.Enabled = editando;
            RG_Paciente.Enabled = editando;
            Feminino.Enabled = editando;
            Masculino.Enabled = editando;
            BtnNovo.Enabled = !editando || visualizando;
            BtnGravar.Enabled = editando;
            BtnExcluir.Enabled = visualizando;
            BtnConsultar.Enabled = !editando || visualizando;
            BtnAlterar.Enabled = visualizando;

            if (editando)
            {
                Nome_Paciente.Focus();
            }
            else
            {
                if (visualizando)
                {
                    BtnAlterar.Focus();
                }
                else
                {
                    BtnNovo.Focus();
                }
            }

        }
        
        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                
                Paciente Paciente = new Paciente();
                Cidade Cidade = new Cidade();
                Convenio Convenio = new Convenio();
                int id;
                int.TryParse(ID_Paciente.Text, out id);
                Convenio = CbbConvenio.SelectedItem as Convenio;
                Paciente.Id = id;
                Cidade = CbbCidade.SelectedItem as Cidade;//Estudar isso;
                Paciente.Bairro = Bairro_Paciente.Text;
                Paciente.Cep = CEP_Paciente.Text;
                Paciente.Cidade = Cidade;
                Paciente.Logradouro = Logradouro_Paciente.Text;
                Paciente.Nascimento = Convert.ToDateTime(DataNascimento_Paciente.Text);
                Paciente.Complemento = Complemento_Paciente.Text;
                Paciente.Convenio = Convenio;
                Paciente.Email = Email_Paciente.Text;
                Paciente.Fonecel1 = Cel1_Paciente.Text;
                Paciente.Fonecel2 = Cel2_Paciente.Text;
                Paciente.Fonecom = Fonecom_Paciente.Text;
                Paciente.FoneRes = Foneres_Paciente.Text;
                Paciente.Nome = Nome_Paciente.Text;
                Paciente.Numero = Num_Paciente.Text;
                Paciente.Rg = RG_Paciente.Text;
                if (Feminino.Checked)
                {
                    Paciente.Sexo = 'F';
                }
                if (Masculino.Checked)
                {
                    Paciente.Sexo = 'M';
                }
                MySqlPacienteRepository.Gravar(Paciente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Paciente: " + ex.ToString());
            }

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente Paciente = new Paciente();
                Cidade Cidade = new Cidade();
                Convenio Convenio = new Convenio();
                int id;
                int.TryParse(ID_Paciente.Text, out id);
                Paciente.Id = id;
                Cidade = CbbCidade.SelectedItem as Cidade;//Estudar isso;
                Paciente.Bairro = Bairro_Paciente.Text;
                Paciente.Cep = CEP_Paciente.Text;
                Paciente.Cidade = Cidade;
                Paciente.Logradouro = Logradouro_Paciente.Text;
                Paciente.Nascimento = Convert.ToDateTime(DataNascimento_Paciente.Text);
                Paciente.Complemento = Complemento_Paciente.Text;
                Paciente.Convenio = Convenio;
                Paciente.Email = Email_Paciente.Text;
                Paciente.Fonecel1 = Cel1_Paciente.Text;
                Paciente.Fonecel2 = Cel2_Paciente.Text;
                Paciente.Fonecom = Fonecom_Paciente.Text;
                Paciente.FoneRes = Foneres_Paciente.Text;
                Paciente.Nome = Nome_Paciente.Text;
                Paciente.Numero = Num_Paciente.Text;
                Paciente.Rg = RG_Paciente.Text;
                if (Feminino.Checked)
                {
                    Paciente.Sexo = 'F';
                }
                if (Masculino.Checked)
                {
                    Paciente.Sexo = 'M';
                }
                MySqlPacienteRepository.Excluir(Paciente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir cidade: " + ex.ToString());
            }
        }
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            HabilitarControles(editando: true);
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Inicializar();
            HabilitarControles(editando: true);
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            var f = new FrmConsPaciente(MySqlPacienteRepository);
            if (f.ShowDialog() == DialogResult.OK)
            {
                Paciente Paciente = new Paciente();
                Cidade Cidade = new Cidade();
                Convenio Convenio = new Convenio();
                ID_Paciente.Text = f.Paciente.Id.ToString();
                Bairro_Paciente.Text = f.Paciente.Bairro;
                CEP_Paciente.Text = f.Paciente.Cep;
                Nome_Paciente.Text = f.Paciente.Nome.ToString();
                RG_Paciente.Text = f.Paciente.Rg.ToString();
                Email_Paciente.Text = f.Paciente.Email.ToString();
                Logradouro_Paciente.Text = f.Paciente.Logradouro.ToString();
                Num_Paciente.Text = f.Paciente.Numero.ToString();
                Complemento_Paciente.Text = f.Paciente.Complemento.ToString();
                //cidade
                //convenio
                DataNascimento_Paciente.Text = f.Paciente.Nascimento.ToString();
                Foneres_Paciente.Text = f.Paciente.FoneRes.ToString();
                Fonecom_Paciente.Text = f.Paciente.Fonecom.ToString();
                Cel1_Paciente.Text = f.Paciente.Fonecel1.ToString();
                Cel2_Paciente.Text = f.Paciente.Fonecel2.ToString();
                if (f.Paciente.Sexo == 'M')
                    Masculino.Checked = true;
                else
                    Feminino.Checked = true;

                HabilitarControles(visualizando: true);


                //terminar de receber parametros;
            }
        }
    }
}
