using gameSuporte.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameSuporte.Mapping
{
    public class MasterUsuarioMapping : IEntityTypeConfiguration<MasterUsuario>
    {
        public void Configure(EntityTypeBuilder<MasterUsuario> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome).HasMaxLength(150);
            builder.Property(p => p.CPF);
            builder.Property(p => p.Email).HasMaxLength(150);
            builder.Property(p => p.Senha).HasMaxLength(150);
            builder.Property(p => p.Perfil).HasColumnType("int");
        }

    }
}