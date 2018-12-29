using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relatorio
{
    public enum LocalRelatorio
    {
        EmbeddedResource, External
    }
    public partial class FrmVisualizadorDeRelatorio : Form
    {

        public LocalReport LocalReport { get { return rpvRelatorio.LocalReport;  } }

        /// <summary>
        /// Construtor do Visualizador de Relatórios
        /// </summary>
        /// <param name="relatorio">Se o local do relatório for externo informar o caminho completo + o nome do relatório que deseja exibir, ex: d:\projeto\relatorios\produtos.rdlc. Se o local for embutido, informar o nome do assembly "." nome da pasta "." nome do relatorio.rdlc, ex: ProjOficina.Relatorio.Orcamento.rdlc</param>
        public FrmVisualizadorDeRelatorio(string relatorio, LocalRelatorio localRelatorio)
        {
            InitializeComponent();
            rpvRelatorio.LocalReport.DataSources.Clear();
            if (localRelatorio == LocalRelatorio.External)
                rpvRelatorio.LocalReport.ReportPath = relatorio;
            else
                rpvRelatorio.LocalReport.ReportEmbeddedResource = relatorio;
            rpvRelatorio.SetDisplayMode(DisplayMode.PrintLayout);
            rpvRelatorio.LocalReport.EnableExternalImages = true;
            rpvRelatorio.ZoomMode = ZoomMode.PageWidth;
            rpvRelatorio.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
        }

        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            
        }

        /// <summary>
        /// Adicionar parâmetros aos relatório.
        /// </summary>
        /// <param name="nome">Nome do parâmetro, deve ser idêntico ao nome criado dentro do relatório.</param>
        /// <param name="valor">Valor a ser atribuido ao parâmetro.</param>
        public void AddParameters(string nome, string valor)
        {
            rpvRelatorio.LocalReport.SetParameters(new ReportParameter(nome, valor));
        }

        /// <summary>
        /// Adicionar um List como uma fonte de dados para o relatório. 
        /// </summary>
        /// <param name="lista">
        /// List a ser adicionada como uma fonte de dados para o relatório.</param>
        /// <param name="DataSourceName">
        /// Informe o nome do DataSet criado dentro do relatório que irá receber a lista.
        /// </param>
        public void AddDataSource(System.Collections.IEnumerable lista, string DataSourceName)
        {
            ReportDataSource rds = new ReportDataSource(DataSourceName, lista);
            rpvRelatorio.LocalReport.DataSources.Add(rds);
        }

        /// <summary>
        /// Adicionar um DataTable como fonte de dados para o relatório. 
        /// </summary>
        /// <param name="dt">
        /// DataTable a ser adicionado como uma fonte de dados para o relatório.</param>
        /// <param name="DataSourceName">
        /// Informe o nome do DataSet criado dentro do relatório que irá receber o DataTable.
        /// </param>
        public void AddDataSource(DataTable dt, string DataSourceName)
        {
            ReportDataSource rds = new ReportDataSource(DataSourceName, dt);
            rpvRelatorio.LocalReport.DataSources.Add(rds);
        }

        private void frmVisualizarDeRelatorio_Load(object sender, EventArgs e)
        {
            this.rpvRelatorio.RefreshReport();
        }
    }
}
