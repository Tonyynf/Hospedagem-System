using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public Pessoa(string Nome, string Sobrenome)
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}";
    }
}