using Microsoft.EntityFrameworkCore;
using EverythingComics.Repository.Mapping;
using EverythingComics.Domain.Entities;

namespace EverythingComics.Repository.Context
{
    public class EverythingComicsContext : DbContext
    {
        public EverythingComicsContext(DbContextOptions<EverythingComicsContext> options)
            : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<PedidoVenda> PedidosVenda { get; set; }
        public DbSet<ItemVenda> ItensVenda { get; set; }
        public DbSet<MovimentacaoEstoque> MovimentacoesEstoque { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aplica as configurações dos arquivos *Map.cs
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new PedidoVendaMap());
            modelBuilder.ApplyConfiguration(new ItemVendaMap());
            modelBuilder.ApplyConfiguration(new MovimentacaoEstoqueMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}