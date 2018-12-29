using ProjAgendamento.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Trabalho.Model;
using Trabalho.Repository.Interface;

namespace Trabalho.View
{
    public partial class FrmCadastroAgendamento : Form
    {
        public Paciente paciente { get; set; }
        BindingList<Exame> listaex = new BindingList<Exame>();
        public IPacienteRepository MySqlPacienteRepository { get; }
        public IMedicoRepository MySqlMedicoRepository { get; }
        public IConvenioRepository MySqlConvenioRepository { get; }
        public IExameRepository MySqlExameRepository { get; }
        public IAgendamentoRepository MySqlAgendamentoRepository { get; }
        public IAgendamentoExameRepository MySqlAgendamentoExameRepository { get; }
        public IMedicoConvenioRepository MySqlMedicoConvenioRepository { get; }
        public IMedicoHorarioRepository MySqlMedicoHorarioRepository { get; }
        int tot;
        public FrmCadastroAgendamento(IExameRepository ExameRepositor, IPacienteRepository PacienteRepositor, IMedicoRepository MedicoRepositor, IConvenioRepository ConvenioRepositor, IAgendamentoRepository AgendamentoRepositor, IAgendamentoExameRepository mySqlAgendamentoExameRepository, IMedicoConvenioRepository mySqlMedicoConvenioRepository, IMedicoHorarioRepository mySqlMedicoHorarioRepository)
        {
            MySqlPacienteRepository =  PacienteRepositor;
            MySqlMedicoRepository = MedicoRepositor;
            MySqlConvenioRepository = ConvenioRepositor;
            MySqlAgendamentoRepository = AgendamentoRepositor;
            MySqlExameRepository = ExameRepositor;
            MySqlAgendamentoExameRepository = mySqlAgendamentoExameRepository;
            MySqlMedicoConvenioRepository = mySqlMedicoConvenioRepository;
            MySqlMedicoHorarioRepository = mySqlMedicoHorarioRepository;
            InitializeComponent();
            InicializarCombos();
        }
        private void textBox2_TextChanged(object sender, EventArgs e){}
        private void label9_Click(object sender, EventArgs e){}
        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if (listaex.Count > 0)
            {
                List<MedicoHorario> horarios = new List<MedicoHorario>();
                
                Agendamento agenda = new Agendamento();

                agenda.Medico = CbbMedico.SelectedItem as Medico;
                agenda.dataagenda = data_agendamento.Value;
                int veri = 0;

                horarios = MySqlMedicoHorarioRepository.GetByMedico((int)agenda.MedicoId).ToList();
                DateTime inicio = horarios[0].datainicial.Date;
                DateTime agendadata = agenda.dataagenda.Date;
                DateTime fim = horarios[0].datafinal.Date;
                if(inicio<=agendadata)
                {
                    MessageBox.Show("TESTE");
                }

                for (int i =0; i< horarios.Count && veri == 0; i++)
                {

                    if(horarios[i].datainicial.Date <= agenda.dataagenda.Date && horarios[i].datafinal.Date >= agenda.dataagenda.Date && horarios[i].atende == true)
                    {
                        veri = 1;
                    }
                }
                if (veri == 1)
                {

                    int id;
                    int.TryParse(ID_Agendamento.Text, out id);
                    agenda.Id = id;
                    agenda.Convenio = CbbConvenio.SelectedItem as Convenio;
                    
                    agenda.data = DateTime.Now;
                    agenda.Medico = CbbMedico.SelectedItem as Medico;
                    agenda.observacao = Observacao.Text;
                    agenda.Paciente = CbbPaciente.SelectedItem as Paciente;
                    agenda.Situacao = CbbSituacao.SelectedItem as Situacao;
                    agenda.total = 0;//Convert.ToDecimal(Total.Text);
                    int cod = MySqlAgendamentoRepository.Gravar(agenda);
                    Exame Exame = new Exame();
                    for (int i = 0; i < listaex.Count; i++)
                    {
                        AgendamentoExame agendamentoexame = new AgendamentoExame();
                        agendamentoexame.Id = cod;
                        Exame.Id = listaex[i].Id;
                        agendamentoexame.Exame = Exame;
                        agendamentoexame.Quantidade = listaex[i].QtdeUnidade;
                        agendamentoexame.QuantidadeUnidade = MySqlExameRepository.Get(listaex[i].Id).QtdeUnidade;
                        agendamentoexame.Total = 0;
                        agendamentoexame.ValorUnidade = agenda.Convenio.ValorUnidade;
                        MySqlAgendamentoExameRepository.Gravar(agendamentoexame);


                    }
                    MessageBox.Show("gravado com sucesso");
                }
                else
                {
                    MessageBox.Show("Horário já ocupado");
                }
            }
            else
                MessageBox.Show("Adicione ao menos um exame");
        }
        public void InicializarCombos()
        {
            List<Paciente> lista = new List<Paciente>();
            
            List<Situacao> situacao = new List<Situacao>();
            List<Convenio> convenio = new List<Convenio>();
            List<Exame> exame = new List<Exame>();
            lista = MySqlPacienteRepository.GetAll().ToList();
            CbbPaciente.DataSource = lista;
            CbbPaciente.DisplayMember = "nome";
            CbbPaciente.ValueMember = "id";

          

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
            Exame ex = CbbExame.SelectedItem as Exame;
            int qtde = Convert.ToInt32(Qtde.Text);
            if (qtde <= ex.QtdeUnidade)
            {
                Exame exa = new Exame();
                exa.Descricao = ex.Descricao;
                exa.QtdeUnidade = qtde;
                exa.Id = ex.Id;
                listaex.Add(exa);
                DgvExames.DataSource = listaex;
                tot = ex.QtdeUnidade+tot;
                ///verificar como faz a conta;
            }
            else
            {
                MessageBox.Show("Quantidade inválida");
            }
           
        }


        public void CbbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

            Paciente paciente = CbbPaciente.SelectedItem as Paciente;
            
            Convenio conv = new Convenio();

            List<Paciente> list_paciente = MySqlPacienteRepository.GetByNome(paciente.Nome).ToList();

            conv = MySqlConvenioRepository.Get(list_paciente.ElementAt(0).ConvenioId);
            List<Convenio> list_convenio = new List<Convenio>();
            list_convenio.Add(conv);
            CbbConvenio.DataSource = list_convenio;
            CbbConvenio.DisplayMember= "nome";
            CbbConvenio.ValueMember = "id";

            Convenio convenio = CbbConvenio.SelectedItem as Convenio;

            List<MedicoConvenio> listaconv = new List<MedicoConvenio>();
            listaconv = MySqlMedicoConvenioRepository.GetByConvenio(convenio.Id).ToList();
            List<Medico> listamed = new List<Medico>();


            for (int i = 0; i < listaconv.Count; i++)
            {

                listamed.Add(listaconv.ElementAt(i).Medico);
            }

            CbbMedico.DataSource = listamed;
            CbbMedico.DisplayMember = "nome";
            CbbMedico.ValueMember = "id";
        }

        private void Observacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbbConvenio_SelectedIndexChanged(object sender, EventArgs e)
        {
            Convenio convenio = CbbConvenio.SelectedItem as Convenio;

            List<MedicoConvenio> listaconv = new List<MedicoConvenio>();
            listaconv = MySqlMedicoConvenioRepository.GetByConvenio(convenio.Id).ToList();
            List<Medico> listamed = new List<Medico>();


            for (int i=0;i<listaconv.Count;i++)
            {
                
                listamed.Add(listaconv.ElementAt(i).Medico);
            }

            CbbMedico.DataSource = listamed;
            CbbMedico.DisplayMember = "nome";
            CbbMedico.ValueMember = "id";
        }

        private void CbbMedico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Exame aux = DgvExames.CurrentRow?.DataBoundItem as Exame;
            if (aux != null)
            {
                Exame aux2;
                BindingList<Exame> aux3 = new BindingList<Exame>();

                for (int i = 0; i < listaex.Count; i++)
                {
                    aux2 = listaex[i];
                    if (aux.Id == aux2.Id)
                    {
                        listaex.Remove(aux2);
                    }
                    else
                    {
                        aux3.Add(aux2);
                    }
                }
                DgvExames.ClearSelection();
                DgvExames.DataSource = aux3;
                listaex = aux3;
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            var f = new FrmConsAgendamento(MySqlAgendamentoRepository);
            if (f.ShowDialog() == DialogResult.OK)
            {
                //colocar campos
                List<Exame> listaexam = new List<Exame>();
                List<AgendamentoExame> listaagendamentoexame = new List<AgendamentoExame>();
                ID_Agendamento.Text = f.Agendamento.Id.ToString();
                int teste = f.Agendamento.Id;
                listaagendamentoexame = MySqlAgendamentoExameRepository.GetByAgendamentoExame(f.Agendamento.Id).ToList();
                for (int i = 0; i < listaagendamentoexame.Count; i++)
                {
                    listaexam.Add(listaagendamentoexame[i].Exame);
                }
                DgvExames.DataSource = listaexam;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Agendamento Agendamento = new Agendamento();
                AgendamentoExame agendamentoExame = new AgendamentoExame();
                Agendamento.Id = Convert.ToInt32(ID_Agendamento.Text);
                agendamentoExame.Id = Agendamento.Id;
                MySqlAgendamentoExameRepository.Excluir(agendamentoExame);
                MySqlAgendamentoRepository.Excluir(Agendamento);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir cidade: " + ex.ToString());
            }
        }

        private void FrmCadastroAgendamento_Load(object sender, EventArgs e)
        {

        }
    }
}
