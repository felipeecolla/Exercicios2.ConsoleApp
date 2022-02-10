                                                                                                                                                                                                                                                                                              using System;

namespace EX4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor A:");
            string strValorA = Console.ReadLine();
            int ValorA = Convert.ToInt32(strValorA);

            Console.WriteLine("Digite valor B:");
            string strValorB = Console.ReadLine();
            int ValorB = Convert.ToInt32(strValorB);

            int ValorC;

            if (ValorA == ValorB)
                ValorC = ValorA + ValorB;

            else ValorC = ValorA * ValorB;

            Console.WriteLine("Valor de C é:" + ValorC);


        }
    }
}
