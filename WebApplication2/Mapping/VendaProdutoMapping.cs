using gameSuporte.Entity;
using GameSuporte.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSuporte.Mapping
{
    public class VendaProdutoMapping : IEntityTypeConfiguration<VendaProduto>
    {

        public void Configure(EntityTypeBuilder<VendaProduto> builder)
        {
            builder.HasKey(p => p.ID);
            builder.Property(p => p.ID).ValueGeneratedOnAdd();
            builder.Property(p => p.Quantidade);
            builder.Property(p => p.DataVenda);


            builder.HasOne<Usuario>(p => p.Usuario).WithMany(p => p.VendaProdutos).HasForeignKey(p => p.UsuarioId);
            builder.HasOne<Produto>(p => p.Produto).WithMany(p => p.VendaProdutos).HasForeignKey(p => p.ProdutoId);

        }

        
    }
}

