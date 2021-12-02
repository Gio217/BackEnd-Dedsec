using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gameSuporte.Entity
{
    public class Endereco
    {
        
        [ForeignKey("Usuario")]
        public int ID { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int CEP { get; set; }

    }
}
