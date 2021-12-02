using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gameSuporte.Entity
{
    public class Categoria
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Produto> Produtos { get; internal set; }
    }
}
