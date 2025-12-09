using AutoMapper;
using EverythingComics.App.ViewModel;
using EverythingComics.Domain.Base;
using EverythingComics.Domain.Entities;
using EverythingComics.Repository.Context;
using EverythingComics.Repository.Repository;
using EverythingComics.Service.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;

namespace EverythingComics.App.Infra
{
    public static class ConfigureDI
    {
        public static IServiceProvider? ServicesProvider { get; private set; }
        public static ServiceCollection services;
        public static void ConfigureServices()
        {
            var dbConfigFile = "Config/DBConfig.txt";
            var strCon = File.ReadAllText(dbConfigFile);
            services = new ServiceCollection();
            services.AddDbContext<EverythingComicsContext>(
                options =>
                {
                    options.LogTo(Console.WriteLine);
                    options.UseMySQL(strCon);
                });

            services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            services.AddScoped<IBaseRepository<Funcionario>, BaseRepository<Funcionario>>();
            services.AddScoped<IBaseRepository<Produto>, BaseRepository<Produto>>();
            services.AddScoped<IBaseRepository<ItemVenda>, BaseRepository<ItemVenda>>();
            services.AddScoped<IBaseRepository<PedidoVenda>, BaseRepository<PedidoVenda>>();
            services.AddScoped<IBaseRepository<MovimentacaoEstoque>, BaseRepository<MovimentacaoEstoque>>();

            services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();
            services.AddScoped<IBaseService<Funcionario>, BaseService<Funcionario>>();
            services.AddScoped<IBaseService<Produto>, BaseService<Produto>>();
            services.AddScoped<IBaseService<ItemVenda>, BaseService<ItemVenda>>();
            services.AddScoped<IBaseService<PedidoVenda>, BaseService<PedidoVenda>>();
            services.AddScoped<IBaseService<MovimentacaoEstoque>, BaseService<MovimentacaoEstoque>>();

            services.AddSingleton(new MapperConfiguration(config =>
                {
                    config.CreateMap<Cliente, ClienteViewModel>();
                    config.CreateMap<Funcionario, FuncionarioViewModel>();
                    config.CreateMap<Produto, ProdutoViewModel>();
                    config.CreateMap<ItemVenda, ItemVendaViewModel>()
                        .ForMember(d => d.ProdutoNome, d => d.MapFrom(src => src.Produto.Nome));
                    config.CreateMap<PedidoVenda, PedidoVendaViewModel>()
                    .ForMember(d => d.ClienteNome, d => d.MapFrom(src => src.Cliente.Nome))
                        .ForMember(d => d.FuncionarioNome, d => d.MapFrom(src => src.Funcionario.Nome));
                    config.CreateMap<MovimentacaoEstoque, MovimentacaoEstoqueViewModel>()
                        .ForMember(d => d.ProdutoNome, d => d.MapFrom(src => src.Produto.Nome));
                }, NullLoggerFactory.Instance).CreateMapper());



            ServicesProvider = services.BuildServiceProvider();
        }
    }
}