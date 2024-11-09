using System;
using System.Windows.Forms;

namespace Cadastro_Amivolta
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Pesquisa pesquisa = new Pesquisa();
            Application.Run(pesquisa); // Abre a tela de carregamento
        }
    }
}
