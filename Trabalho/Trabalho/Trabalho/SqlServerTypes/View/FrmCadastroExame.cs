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
    public partial class FrmCadastroExame : Form
    {
        public IExameRepository MySqlExameRepository { get; }
        public FrmCadastroExame(IExameRepository mySqlExameRepository)
        {
            InitializeComponent();
            MySqlExameRepository = mySqlExameRepository;
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Exame exame = new Exame();
            exame.Id = Convert.ToInt32(ID_exame.Text);
            exame.QtdeUnidade = Convert.ToInt32(Quantidade_exame.Text);
            exame.Descricao = Descricao_exame.Text;
            MySqlExameRepository.Gravar(exame);

        }
    }
}
