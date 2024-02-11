using System;
using System.Linq;



namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, soma;

            Console.WriteLine("Digite Alguns Numeros");
            x = int.Parse(Console.ReadLine());
            soma = 0;

            

            while (x != 0)
            {
                soma = soma + x;
                x = int.Parse(Console.ReadLine());

            }

            Console.WriteLine($" A soma de todos os numeros são: {soma}");

          Console.ReadLine();

        }
    }
}