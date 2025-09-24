using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Hospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastraHospedes(List<Pessoa> hospedes){
        
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;

            string tipoSuite = suite.TipoSuite;
            int capacidade = suite.Capacidade;
            decimal valorDiaria = suite.ValorDiaria;
        }

        public int ObterQuantidadeDeHospedes(){
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria(){
            return 0;
        }

    }
}