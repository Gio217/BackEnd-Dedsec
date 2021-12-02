using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using GameSuporte.Entity;

namespace gameSuporte.Entity
{
    public class Produto
    {
        [ForeignKey("Categoria")]
        public int ID { get; set; }
        public int CategoriaId{ get; set; }
        public Categoria Categoria { get; set; }

        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public IEnumerable<VendaProduto> VendaProdutos { get; internal set; }
    }
}
