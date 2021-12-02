using gameSuporte.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameSuporte.Entity
{
    public class VendaProduto
    {
        [ForeignKey("Usuario")]
        public int ID { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        [ForeignKey("Produto")]
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
