using EverythingComics.App.Cadastros;
using EverythingComics.App.Infra;
using EverythingComics.Repository.Context;
using Microsoft.EntityFrameworkCore;      
using Microsoft.Extensions.DependencyInjection; 

namespace EverythingComics.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            ConfigureDI.ConfigureServices();

            using (var scope = ConfigureDI.ServicesProvider.CreateScope())
            {
                try
                {
                    var db = scope.ServiceProvider.GetRequiredService<EverythingComicsContext>();

                    if (db.Database.CanConnect())
                    {
                        MessageBox.Show("SUCESSO! O sistema conectou no MySQL perfeitamente.", "Teste de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("O sistema não conseguiu conectar no banco.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro grave ao tentar conectar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Application.Run(new MainForm());
        }
    }
}