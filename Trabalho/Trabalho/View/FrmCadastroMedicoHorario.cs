using ProjAgendamento.Repository;
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
    public partial class FrmCadastroMedicoHorario : Form
    {
        IMedicoHorarioRepository MySqlMedicoHorarioRepository { get; }
        IMedicoRepository MySqlMedicoRepository { get; }
        public FrmCadastroMedicoHorario(IMedicoRepository mySqlMedicoRepository, IMedicoHorarioRepository mySqlMedicoHorarioRepository)
        {
            MySqlMedicoHorarioRepository = mySqlMedicoHorarioRepository;
            MySqlMedicoRepository = mySqlMedicoRepository;
            InitializeComponent();
            InicializaCombo();
        }
        public void InicializaCombo()
        {
            List<Medico> listamed = new List<Medico>();
            listamed = MySqlMedicoRepository.GetAll().ToList();
            CbbMedico.DataSource = listamed;
            CbbMedico.DisplayMember = "nome";
            CbbMedico.ValueMember = "id";
        }
        private void BtnGravar_Click(object sender, EventArgs e)
        {
            int id;
            TimeSpan hora;
            MedicoHorario medho = new MedicoHorario();
            int.TryParse(Id_medho.Text, out id);
            if (Chatende.Checked)
                medho.atende = true;
            else
                medho.atende = false;
            medho.datafinal = DtaFinal.Value;
            medho.datainicial = DtaInicial.Value;

            hora = HraInicial.Value.TimeOfDay;
            if (hora.Minutes < 30)
                hora = new TimeSpan(hora.Hours, 30, 00);
            else
                hora = new TimeSpan(hora.Hours+1, 00, 00);
            medho.horainicial = hora;
            hora = HraFinal.Value.TimeOfDay;
            if (hora.Minutes < 30)
                hora = new TimeSpan(hora.Hours, 30, 00);
            else
                hora = new TimeSpan(hora.Hours + 1, 00, 00);
            medho.horafinal = hora;
            medho.Medico = CbbMedico.SelectedItem as Medico;
            medho.Observacao = Observacao.Text;
            MySqlMedicoHorarioRepository.Gravar(medho);
        }

        private void Observacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                MedicoHorario mh = new MedicoHorario();
                mh.Id = Convert.ToInt32(Id_medho.Text);
                MySqlMedicoHorarioRepository.Excluir(mh);
                MessageBox.Show("Excluido com sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao excluir o médico horario");
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {

            var f = new FrmConsMedicoHorario(MySqlMedicoHorarioRepository,MySqlMedicoRepository);
            if (f.ShowDialog() == DialogResult.OK)
            {
                Id_medho.Text = f.MedicoHorario.Id.ToString();
                if (f.MedicoHorario.atende)
                    Chatende.Checked = true;
                else
                    Chatende.Checked = false;

                DtaInicial.Text = f.MedicoHorario.datainicial.ToString();
                DtaFinal.Text = f.MedicoHorario.datafinal.ToString();
                HraInicial.Text = f.MedicoHorario.horainicial.ToString();
                HraFinal.Text = f.MedicoHorario.horafinal.ToString();
                Medico medico = new Medico();
                medico = f.MedicoHorario.Medico;
                CbbMedico.SelectedItem = medico;
                Observacao.Text = f.MedicoHorario.Observacao.ToString();
                //HabilitarControles(visualizando: true);
            }
        }
    }
}
