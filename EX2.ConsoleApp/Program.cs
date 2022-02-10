using System;

namespace EX2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor A:");
            string strValorA = (Console.ReadLine());
            int ValorA = Convert.ToInt32(strValorA);

            Console.WriteLine("Digite o valor B:");
            string strValorB = (Console.ReadLine());
            int ValorB = Convert.ToInt32(strValorB);

            Console.WriteLine("Digite o valor C");
            string strValorC = (Console.ReadLine()); 
            int ValorC = Convert.ToInt32(strValorC);

            if (ValorA > ValorB && ValorB > ValorC)
                Console.WriteLine("{0}, {1}, {2}", ValorA, ValorB, ValorC);

            else if (ValorA > ValorB && ValorB > ValorC && ValorC > ValorB)
                Console.WriteLine("{0}, {1}, {2}", ValorA, ValorC, ValorB);

            else if (ValorB > ValorA && ValorA > ValorC)
                Console.WriteLine("{0}, {1}, {2}", ValorB, ValorA, ValorC);

            else if (ValorB > ValorA && ValorB > ValorC && ValorC > ValorA)
                Console.WriteLine("{0}, {1}, {2}", ValorB, ValorC, ValorA);

            else if (ValorC > ValorB && ValorB > ValorA)
                Console.WriteLine("{0}, {1}, {2}", ValorC, ValorB, ValorA);

            else if (ValorC > ValorB && ValorA > ValorB)
                Console.WriteLine("{0}, {1}, {2}", ValorC, ValorB, ValorA);

            Console.ReadKey();



        }
        

    }
}
