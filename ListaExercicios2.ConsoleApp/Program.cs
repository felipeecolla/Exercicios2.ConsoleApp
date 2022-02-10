using System;

namespace ListaDeExercicios2.ConsoleApp
{
    internal class Program
    { /* Faça um algoritmo que leia os valores A, B, C e 
        imprima na tela se a soma de A + B é menor que C.
       */
        static void Main(string[] args)
        {
            double a;


            Console.WriteLine("Digite o valor de A:");
            a = Convert.ToDouble(Console.ReadLine());

            double b;

            Console.WriteLine("Digite o valor de B:");
            b = Convert.ToDouble(Console.ReadLine());

            double c;

            Console.WriteLine("Digite o valor de C:");
            c = Convert.ToDouble(Console.ReadLine());

            if (a + b < c)
            {
                Console.WriteLine("A + B é menor que C!");
            }

            

            else
            {
                Console.WriteLine("A + B é maior ou igual a C!");

            }


            Console.ReadKey();









        }
    }
}

        }
    }
}
