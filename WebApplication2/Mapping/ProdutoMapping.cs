using gameSuporte.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameSuporte.Mapping
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).ValueGeneratedOnAdd();
            builder.Property(p => p.Titulo).HasMaxLength(150);
            builder.Property(p => p.Valor);
            builder.Property(p => p.Descricao).HasMaxLength(150);
           


            builder.HasOne<Categoria>(p => p.Categoria).WithMany(p => p.Produtos).HasForeignKey(p => p.CategoriaId);

        }

    }
}