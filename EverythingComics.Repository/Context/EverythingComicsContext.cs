using Microsoft.EntityFrameworkCore;
using EverythingComics.Repository.Mapping;
using EverythingComics.Domain.Entities;

namespace EverythingComics.Repository.Context
{
    public class EverythingComicsContext : DbContext
    {
        public EverythingComicsContext(DbContextOptions<EverythingComicsContext> options = null)
            : base()
        { 
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=everythingcomics;user=root;password=");
        }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<PedidoVenda> PedidosVenda { get; set; }
        public DbSet<ItemVenda> ItensVenda { get; set; }
        public DbSet<MovimentacaoEstoque> MovimentacoesEstoque { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new ItemVendaMap());
            modelBuilder.ApplyConfiguration(new PedidoVendaMap());
            modelBuilder.ApplyConfiguration(new MovimentacaoEstoqueMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}