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
        public IMedicoRepository MySqlMedicoRepository { get; }
        
        public FrmCadastroMedico(IMedicoRepository mySqlMedicoRepository)
        {
            InitializeComponent();
            MySqlMedicoRepository = mySqlMedicoRepository;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCadastroMedico_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico = new Medico();
                medico.Crm = CRM_medico.Text;
                medico.Fonecel1 = Fone1_medico.Text;
                medico.Fonecel2 = Fone2_medico.Text;
                medico.Nome = Nome_medico.Text;
                medico.Id = Convert.ToInt32(ID_medico.Text);///verificar como passar o id 0 ou id do medico a alterar
                MySqlMedicoRepository.Gravar(medico);
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
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {


                Medico medico = new Medico();
                medico.Id = Convert.ToInt32(ID_medico.Text);
                MySqlMedicoRepository.Excluir(medico);
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


                ID_medico.Text = f.Medico.Id.ToString();
                Nome_medico.Text = f.Medico.Nome.ToString();
                CRM_medico.Text = f.Medico.Crm.ToString();
                Fone1_medico.Text = f.Medico.Fonecel1.ToString();
                Fone2_medico.Text = f.Medico.Fonecel2.ToString();

                //HabilitarControles(visualizando: true);


                //terminar de receber parametros;
            }
        }
    }
}
