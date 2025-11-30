using EverythingComics.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EverythingComics.Repository.Mapping
{
    public class MovimentacaoEstoqueMap : IEntityTypeConfiguration<MovimentacaoEstoque>
    {
        public void Configure(EntityTypeBuilder<MovimentacaoEstoque> builder)
        {
            builder.ToTable("movimentacaoEstoque");

            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Id)
                .HasColumnName("id_movEstoque");

            builder.Property(prop => prop.DataMovimentacao)
                .HasColumnName("data_mov")
                .HasColumnType("datetime")
                .HasDefaultValueSql("current_timestamp");

            builder.Property(prop => prop.TipoMovimentacao)
                .IsRequired()
                .HasColumnName("tipo_mov"); 

            builder.Property(prop => prop.Quantidade)
                .IsRequired()
                .HasColumnName("qtd_mov");

            builder.Property(prop => prop.Observacao)
                .HasColumnName("obs_mov")
                .HasMaxLength(100);

            builder.HasOne(prop => prop.Produto)
                .WithMany()
                .HasForeignKey("cod_prod") 
                .IsRequired();
        }
    }
}