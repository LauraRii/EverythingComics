using EverythingComics.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EverythingComics.Repository.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("cliente");

            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Id)
                .HasColumnName("cod_clnt");

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnName("nome_clnt")
                .HasMaxLength(40);

            builder.Property(prop => prop.Cnpj)
                .IsRequired()
                .HasColumnName("cnpj")
                .HasMaxLength(14);

            builder.Property(prop => prop.Cep)
                .HasColumnName("cep_loja")
                .HasMaxLength(8);

            builder.Property(prop => prop.Rua)
                .HasColumnName("rua")
                .HasMaxLength(40);

            builder.Property(prop => prop.Bairro)
                .HasColumnName("bairro")
                .HasMaxLength(40);

            builder.Property(prop => prop.Cidade)
                .HasColumnName("cidade")
                .HasMaxLength(40);

            builder.Property(prop => prop.Estado)
                .HasColumnName("estado")
                .HasMaxLength(2);
        }
    }
}