using gameSuporte.Entity;
using gameSuporte.Mapping;
using GameSuporte.Entity;
using GameSuporte.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSuporte.Context
{
    public class MyContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<MasterUsuario> MasterUsuarios { get; set; }
        public DbSet<VendaProduto> VendaProdutos { get; set; }
        public object Categoria { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer("data source=45.93.100.120,1433;initial catalog=FS09;persist security info=True;user id=FS09;password=65431387;MultipleActiveResultSets=True;App=exeEf;");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            base.OnModelCreating(builder);
           
            builder.Entity<Usuario>(new UsuarioMapping().Configure);
            builder.Entity<Produto>(new ProdutoMapping().Configure);
            builder.Entity<Endereco>(new EnderecoMapping().Configure);
            builder.Entity<Categoria>(new CategoriaMapping().Configure);
            builder.Entity<MasterUsuario>(new MasterUsuarioMapping().Configure);
            builder.Entity<VendaProduto>(new VendaProdutoMapping().Configure);
        }
    }
}
