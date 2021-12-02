using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameSuporte.Entity;

namespace gameSuporte.Entity
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime DataNasci { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Perfil Perfil { get; set; }
        

        public IEnumerable<Endereco> Enderecos { get; internal set; }
        public IEnumerable<VendaProduto> VendaProdutos { get; internal set; }
    }
}
