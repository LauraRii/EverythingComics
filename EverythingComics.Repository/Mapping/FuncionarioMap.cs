using EverythingComics.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EverythingComics.Repository.Mapping
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("funcionario");

            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Id)
                .HasColumnName("cod_func");

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnName("nome_func")
                .HasMaxLength(40);

            builder.Property(prop => prop.Cargo)
                .IsRequired()
                .HasColumnName("cargo")
                .HasMaxLength(40);

            builder.Property(prop => prop.Departamento)
                .HasColumnName("departamento")
                .HasMaxLength(40);

            builder.Property(prop => prop.Cpf)
                .IsRequired()
                .HasColumnName("cpf")
                .HasMaxLength(11);

            builder.Property(prop => prop.Celular)
                .HasColumnName("celular")
                .HasMaxLength(11);

            builder.Property(prop => prop.DataNascimento)
                .IsRequired()
                .HasColumnName("data_nasc")
                .HasColumnType("date");

            builder.Property(prop => prop.Salario)
                .HasColumnName("salario")
                .HasPrecision(10, 2); // Importante para decimal(10,2)

            builder.Property(prop => prop.Status)
                .HasColumnName("status_func")
                .HasMaxLength(40);
        }
    }
}