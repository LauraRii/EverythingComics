using EverythingComics.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EverythingComics.Repository.Mapping
{
    public class ItemVendaMap : IEntityTypeConfiguration<ItemVenda>
    {
        public void Configure(EntityTypeBuilder<ItemVenda> builder)
        {
            builder.ToTable("itemVenda");

            builder.Ignore(prop => prop.Id);

            builder.HasKey("PedidoId", "ProdutoId");

            builder.Property(prop => prop.Quantidade)
                .IsRequired()
                .HasColumnName("qtd_item");

            builder.Property(prop => prop.PrecoUnitario)
                .IsRequired()
                .HasColumnName("preco_unit")
                .HasPrecision(10, 2);

            builder.Property(prop => prop.ValorTotal)
                .HasColumnName("valor_total")
                .HasPrecision(10, 2);

            builder.HasOne(prop => prop.Pedido)
                .WithMany()
                .HasForeignKey("PedidoId") 
                .HasConstraintName("FK_ItemVenda_Pedido");

            builder.Property("PedidoId").HasColumnName("id_pedVenda");


            builder.HasOne(prop => prop.Produto)
                .WithMany()
                .HasForeignKey("ProdutoId")
                .HasConstraintName("FK_ItemVenda_Produto");

            builder.Property("ProdutoId").HasColumnName("cod_prod");
        }
    }
}