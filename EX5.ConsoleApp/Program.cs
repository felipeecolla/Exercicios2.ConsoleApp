using System;

namespace EX5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número qualquer:");
            string strNumero = Console.ReadLine();
            int numero = Convert.ToInt32(strNumero);
            //a % diz que se o resto for dividido por 2 e der "0" o número é par
            if (numero % 2 == 0)
                Console.WriteLine("Este número é PAR!");

            else
                Console.WriteLine("Este número é IMPAR!");

        }
    }
}
