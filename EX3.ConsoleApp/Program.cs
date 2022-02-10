using System;

namespace EX3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso:");
            string strPeso = Console.ReadLine();
            double peso = Convert.ToDouble(strPeso);

            Console.WriteLine("Digite sua altura:");
            string strAltura = Console.ReadLine();
            double altura = Convert.ToDouble(strAltura);

            double imc = peso / Math.Pow(altura, 2);

            if (imc < 18.5)
                Console.WriteLine("Abaixo do peso");

            else if (imc > 18.5 && imc <= 25)
                Console.WriteLine("Peso normal");

            else if (imc > 25 && imc <= 30)
                Console.WriteLine("Acima do peso");

            else if (imc >= 30)
                Console.WriteLine("Obeso");

            Console.ReadKey();

        }
    }
}
