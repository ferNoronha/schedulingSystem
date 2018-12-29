using ProjAgendamento.Repository;
using ProjDesignPattern.Repository.MySqlRepository;
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
    public partial class FrmCadastroMedico : Form
    {
        public IMedicoConvenioRepository MySqlMedicoConvenioRepository { get; }
        public IMedicoHorarioRepository MySqlMedicoHorarioRepository { get; }
        public IMedicoRepository MySqlMedicoRepository { get; }
        BindingList<Convenio> listacon = new BindingList<Convenio>();
        public IConvenioRepository MySqlConvenioRepository { get; }
        public IAgendamentoRepository MySqlAgendamentoRepository { get; }
        public IAgendamentoExameRepository MySqlAgendamentoExameRepository { get; }
        public FrmCadastroMedico(IAgendamentoRepository mySqlAgendamentoRepository, IMedicoHorarioRepository mySqlMedicoHorarioRepository, IMedicoConvenioRepository mySqlMedicoConvenioRepository, IMedicoRepository mySqlMedicoRepository, IConvenioRepository mySqlConvenioRepository,  IAgendamentoExameRepository mySqlAgendamentoExameRepository)
        {
            InitializeComponent();
            MySqlMedicoRepository = mySqlMedicoRepository;
            MySqlAgendamentoRepository = mySqlAgendamentoRepository;
            MySqlMedicoHorarioRepository = mySqlMedicoHorarioRepository;
            MySqlMedicoConvenioRepository = mySqlMedicoConvenioRepository;
            MySqlConvenioRepository = mySqlConvenioRepository;
            MySqlAgendamentoExameRepository = mySqlAgendamentoExameRepository;
            InicializarCombos();
            
        }
        public void InicializarCombos()
        {
            List<Convenio> convenio = new List<Convenio>();
            convenio = MySqlConvenioRepository.GetAll().ToList();
            CbbConvenio.DataSource = convenio;
            CbbConvenio.DisplayMember = "nome";
            CbbConvenio.ValueMember = "id";
        }
        private void textBox1_TextChanged(object sender, EventArgs e){        }
        private void FrmCadastroMedico_Load(object sender, EventArgs e){        }
        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listacon.Count > 0)
                {
                    int id;
                    int.TryParse(ID_medico.Text, out id);
                    Medico medico = new Medico();
                    medico.Crm = CRM_medico.Text;
                    medico.Fonecel1 = Fone1_medico.Text;
                    medico.Fonecel2 = Fone2_medico.Text;
                    medico.Id = id;
                    medico.Nome = Nome_medico.Text;///verificar como passar o id 0 ou id do medico a alterar
                    medico.Id = MySqlMedicoRepository.Gravar(medico);

                    for (int i = 0; i < listacon.Count; i++)
                    {
                        MedicoConvenio mc = new MedicoConvenio();
                        mc.Medico = medico;
                        mc.Convenio = listacon.ElementAt(i);
                        MedicoConvenio m = MySqlMedicoConvenioRepository.GetByMedicoConvenio(mc);
                        if(m==null)
                            MySqlMedicoConvenioRepository.Gravar(mc);

                    }
                    MessageBox.Show("Gravado com sucesso");
                }
                else
                    MessageBox.Show("Selecione um convenio");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao gravar médico: " + ex.ToString());
            }
        }

        private void BtnCadastrarConvenio_Click(object sender, EventArgs e)
        {
            var f = Dependencias.Container.GetInstance<FrmCadastroConvenio>();
            f.Show();
            List<Convenio> convenio = new List<Convenio>();
            convenio = MySqlConvenioRepository.GetAll().ToList();
            CbbConvenio.DataSource = convenio;
            CbbConvenio.DisplayMember = "nome";
            CbbConvenio.ValueMember = "id";
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico = new Medico();
                int id = Convert.ToInt32(ID_medico.Text);
                medico.Id = id;
                Agendamento agendamento = new Agendamento();
                agendamento.Medico= medico;
                MySqlMedicoConvenioRepository.Excluir(Convert.ToInt32(ID_medico.Text));
                MySqlMedicoHorarioRepository.ExcluirpeloMedico(Convert.ToInt32(ID_medico.Text));

                AgendamentoExame ae = new AgendamentoExame();
                List<Agendamento>  agendamentos = MySqlAgendamentoRepository.GetByMedico(Convert.ToInt32(ID_medico.Text)).ToList();
                if (agendamentos != null)
                {
                    for(int i =0; i<agendamentos.Count; i++)
                    {
                        ae.Id = agendamentos.ElementAt(i).Id;
                        MySqlAgendamentoExameRepository.Excluir(ae);

                    }
                }
                MySqlAgendamentoRepository.ExcluirByMedico(agendamento);
                MySqlAgendamentoRepository.Excluir(agendamento);
                ///MySqlAgendamentoRepository.  tirar do agendamento e do agendamentoexame se der tempo
                MySqlMedicoRepository.Excluir(medico);
                MessageBox.Show("Excluido com Sucesso.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao excluir médico: " + ex.ToString());
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {

            var f = new FrmConsMedico(MySqlMedicoRepository);
            if (f.ShowDialog() == DialogResult.OK)
            {
                Medico medico = new Medico();

                List<MedicoConvenio> listamedcon = new List<MedicoConvenio>();
                ID_medico.Text = f.Medico.Id.ToString();
                int teste = f.Medico.Id;
                listamedcon = MySqlMedicoConvenioRepository.Getporidmed(f.Medico.Id).ToList();
                for(int i=0;i<listamedcon.Count;i++)
                {
                    listacon.Add(listamedcon[i].Convenio);
                }
                DgvConvenio.DataSource = listacon;
                Nome_medico.Text = f.Medico.Nome.ToString();
                CRM_medico.Text = f.Medico.Crm.ToString();
                Fone1_medico.Text = f.Medico.Fonecel1.ToString();
                Fone2_medico.Text = f.Medico.Fonecel2.ToString();

                //HabilitarControles(visualizando: true);


                //terminar de receber parametros;
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Convenio con = CbbConvenio.SelectedItem as Convenio;
            Convenio co = new Convenio();
            co.Id = con.Id;
            co.Nome = con.Nome;
            co.ValorUnidade = con.ValorUnidade;     
            listacon.Add(co);
            DgvConvenio.DataSource = listacon;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Convenio aux = DgvConvenio.CurrentRow?.DataBoundItem as Convenio;
            if (aux != null)
            {
                Convenio aux2;
                BindingList<Convenio> aux3 = new BindingList<Convenio>();

                for (int i = 0; i < listacon.Count; i++)
                {
                    aux2 = listacon[i];
                    if (aux.Id == aux2.Id)
                    {
                        listacon.Remove(aux2);
                    }
                    else
                    {
                        aux3.Add(aux2);
                    }
                }
                DgvConvenio.ClearSelection();
                DgvConvenio.DataSource = aux3;
                listacon = aux3;
            }
        }
    }
}
