using EverythingComics.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EverythingComics.Repository.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("produto");

            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Id)
                .HasColumnName("cod_prod");

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnName("nome_prod")
                .HasMaxLength(40);

            builder.Property(prop => prop.QuantidadeEstoque)
                .HasColumnName("qtd_estoque")
                .HasDefaultValue(0);

            builder.Property(prop => prop.DataCriacao)
                .HasColumnName("data_criacaoProd")
                .HasColumnType("date");

            builder.Property(prop => prop.Preco)
                .IsRequired()
                .HasColumnName("preco_prod")
                .HasPrecision(10, 2);
        }
    }
}