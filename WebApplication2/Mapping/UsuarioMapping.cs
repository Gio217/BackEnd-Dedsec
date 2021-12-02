using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using gameSuporte.Entity;
using Microsoft.EntityFrameworkCore;

namespace gameSuporte.Mapping
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome).HasMaxLength(150);
            builder.Property(p => p.Perfil).HasColumnType("int");
            builder.Property(p => p.Senha).HasMaxLength(15);
            builder.Property(p => p.DataNasci);
            

        }

    }
}
