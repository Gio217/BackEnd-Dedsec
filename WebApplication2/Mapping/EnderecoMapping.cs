using gameSuporte.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameSuporte.Mapping
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).ValueGeneratedOnAdd();
            builder.Property(p => p.Rua).HasMaxLength(150);
            builder.Property(p => p.Numero);
            builder.Property(p => p.Complemento).HasMaxLength(150);
            builder.Property(p => p.Bairro).HasMaxLength(150);
            builder.Property(p => p.Cidade).HasMaxLength(30);
            builder.Property(p => p.CEP);
            

            builder.HasOne<Usuario>(p => p.Usuario).WithMany(p => p.Enderecos).HasForeignKey(p => p.UsuarioId);

        }
    }
}
