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
        Reserva reserva1 = new Reserva();
        Suite suite = new Suite();

        reserva1.CadastrarSuite(suite);
        
        


    }
}

