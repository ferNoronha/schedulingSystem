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
    public partial class FrmConsMedicoHorario : Form
    {
        IMedicoHorarioRepository MySqlMedicoHorarioRepository { get; }
        IMedicoRepository MySqlMedicoRepository { get; }
        public MedicoHorario MedicoHorario { get; set; }
        public FrmConsMedicoHorario(IMedicoHorarioRepository mySqlMedicoHorarioRepository, IMedicoRepository mySqlMedicoRepository)
        {
            MySqlMedicoRepository = mySqlMedicoRepository;
            MySqlMedicoHorarioRepository = mySqlMedicoHorarioRepository;
            InitializeComponent();
            InicializarCombos();
        }
        public void InicializarCombos()
        {
            List<Medico> listamed = new List<Medico>();
            listamed = MySqlMedicoRepository.GetAll().ToList();
            CbbMedico.DataSource = listamed;
            CbbMedico.DisplayMember = "nome";
            CbbMedico.ValueMember = "id";
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            List<MedicoHorario> lista = new List<MedicoHorario>();
            Medico medho = new Medico();
            medho = CbbMedico.SelectedItem as Medico;
            lista = MySqlMedicoHorarioRepository.GetByMedico(medho.Id).ToList();
            
            DgvMedicoHorario.DataSource = lista;
            if (lista.Count == 0)
            {
                MessageBox.Show("Nenhum Horario Encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            MedicoHorario = DgvMedicoHorario.CurrentRow?.DataBoundItem as MedicoHorario;
            if (MedicoHorario != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
