using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using Hospedagem.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Suite suite = new Suite("Premium", 2, 50.00M);

        Reserva reserva = new Reserva(13);
        reserva.CadastrarSuite(suite);

        List<Pessoa> hospedes = new List<Pessoa>()
        {
            new Pessoa("Anthony", "Encarnação"),
            new Pessoa("Lara", "Hill")
        };

        reserva.CadastraHospedes(hospedes);

        Console.WriteLine("\nDADOS DA RESERVA");
        Console.WriteLine($"\nSuite: {reserva.Suite.TipoSuite}");
        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeDeHospedes()}");
        Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria().ToString("C")}\n");
    }
}

