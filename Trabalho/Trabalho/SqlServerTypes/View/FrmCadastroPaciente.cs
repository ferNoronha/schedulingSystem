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
        public IPacienteRepository MySqlPacienteRepository { get; }
        public FrmCadastroPaciente(IPacienteRepository mySqlPacienteRepository)
        {
            InitializeComponent();
            HabilitarControles();
            MySqlPacienteRepository = mySqlPacienteRepository;
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
                Convenio = CbbConvenio.SelectedItem as Convenio;
                if (ID_Paciente != null)
                {
                    Paciente.Id = Convert.ToInt32(ID_Paciente);
                }
                else
                    Paciente.Id = 0;
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
    }
}