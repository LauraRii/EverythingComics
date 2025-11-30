using EverythingComics.Domain.Base;
using EverythingComics.Repository.Context;
using EverythingComics.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace EverythingComics.App.Infra
{
    public static class ConfigureDI
    {
        public static IServiceProvider? ServicesProvider { get; private set; }

        public static void ConfigureServices()
        {
            var services = new ServiceCollection();

            // 1. Configurar o caminho para ler o appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            var configuration = builder.Build();

            // 2. Configurar o Banco de Dados MySQL
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<EverythingComicsContext>(options =>
                options.UseMySQL(connectionString));

            // 3. Configurar os Repositórios (Genérico)
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            // 4. (Opcional) Se você usar injeção dentro dos Forms, registre eles aqui:
            // services.AddTransient<MainForm>();

            // Constrói o provedor
            ServicesProvider = services.BuildServiceProvider();
        }
    }
}