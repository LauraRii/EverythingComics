using EverythingComics.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EverythingComics.Repository.Mapping
{
    public class PedidoVendaMap : IEntityTypeConfiguration<PedidoVenda>
    {
        public void Configure(EntityTypeBuilder<PedidoVenda> builder)
        {
            builder.ToTable("pedidoVenda");

            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Id)
                .HasColumnName("id_pedVenda");

            builder.Property(prop => prop.DataCriacao)
                .HasColumnName("data_criacaoVenda")
                .HasColumnType("date")
                .HasDefaultValueSql("current_date"); 

            builder.Property(prop => prop.DataEntrega)
                .HasColumnName("data_entrega")
                .HasColumnType("date");

            builder.Property(prop => prop.Status)
                .HasColumnName("status_pedVenda")
                .HasMaxLength(40);

            builder.Property(prop => prop.ObservacaoStatus)
                .HasColumnName("obs_status")
                .HasMaxLength(100);

            builder.HasOne(prop => prop.Funcionario)
                .WithMany() 
                .HasForeignKey("cod_func") 
                .IsRequired();

            builder.HasOne(prop => prop.Cliente)
                .WithMany()
                .HasForeignKey("cod_clnt")
                .IsRequired();
        }
    }
}