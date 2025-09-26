using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Hospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }


        public void CadastraHospedes(List<Pessoa> hospedes)
        {
        
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;

            string tipoSuite = suite.TipoSuite;
            int capacidade = suite.Capacidade;
            decimal valorDiaria = suite.ValorDiaria;

            Console.Write("Digite o tipo de suite:");
            tipoSuite = Console.ReadLine();

            Console.Write("Digite a capacidade da suite:");
            capacidade = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da diária:");
            valorDiaria = decimal.Parse(Console.ReadLine());
        }

        public int ObterQuantidadeDeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados > 10)
            {
                decimal desconto = valor * 0.10M;
                decimal valorComDesconto = valor - desconto;

                return valorComDesconto;
            }else{
                return valor;
            }
        }

    }
}
