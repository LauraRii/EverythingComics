using EverythingComics.App.Infra; // Vai dar erro se não criar a classe ConfigureDI abaixo
using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace EverythingComics.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ConfigureDI.ConfigureServices();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}