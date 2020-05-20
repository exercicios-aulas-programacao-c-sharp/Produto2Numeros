using System;

namespace Produto2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            string entradaNumeroUm;
            string entradaNumeroDois;
            
            double numeroUm;
            double numeroDois;

            double produto;

            Console.WriteLine("---Produto de dois números---");
            
            Console.Write("Digite o primeiro número:\t");
            entradaNumeroUm = Console.ReadLine();
            
            Console.Write("Digite o segundo número:\t");
            entradaNumeroDois = Console.ReadLine();

            numeroUm = Convert.ToDouble(entradaNumeroUm);
            numeroDois = Convert.ToDouble(entradaNumeroDois);

            produto = numeroUm * numeroDois;

            Console.WriteLine($"O produto de {numeroUm} e {numeroDois} é {produto}");

        }
    }
}
