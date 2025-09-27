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
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }


        public Reserva(int DiasReservados)
        {
            this.DiasReservados = DiasReservados;  
            Hospedes = new List<Pessoa>();
        }

        public void CadastraHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count() <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hóspedes excede a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
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
                decimal desconto = valor * 0.90M;
                decimal valorComDesconto = valor - desconto;

                return valorComDesconto;
            }else{
                return valor;
            }
        }

    }
}
