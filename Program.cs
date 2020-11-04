using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_10_Calcula_Poupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupança");

            double valorInvestido = 1000;
            int mesInvestido = 1;



            while (mesInvestido <= 12)
            {

                valorInvestido = valorInvestido + valorInvestido * 0.0036;

                Console.WriteLine("mes " + mesInvestido + " gerou um total de R$" + valorInvestido);

                mesInvestido++;


            }
            Console.ReadLine();




        }
    }
}
