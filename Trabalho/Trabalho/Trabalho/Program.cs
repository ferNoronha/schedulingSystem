using SimpleInjector.Lifestyles;
using System;
using System.Windows.Forms;
using Trabalho.Model;

namespace Trabalho
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ///pegar do aprender a alteracao///
            ///pegar dependencia///
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (ThreadScopedLifestyle.BeginScope(Dependencias.Container))
            {
                Dependencias.Configurar();
                Application.Run(new Main());
            }
        }
    }
}
