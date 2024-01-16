using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome e a idade da primeira pessoa: ");

            string[] vet = Console.ReadLine().Split(' ');
            string nome1 = vet[0];
            int idade1 = int.Parse(vet[1]);

            Console.WriteLine($"O nome da primeira pessoa é {nome1} e a idade dela é {idade1}");

            Console.WriteLine(" ");

            Console.WriteLine("Digite o nome e a idade da segunda pessoa: ");
            vet = Console.ReadLine().Split(' ');
            string nome2 = vet[0];
            int idade2 = int.Parse(vet[1]);

            Console.WriteLine($"O nome da primeira pessoa é {nome2} e a idade dela é {idade2}");

            double media = (idade1 + idade2) / 2.00;

            Console.WriteLine($"A media da idade de {nome1} e {nome2} é {media.ToString("F1", CultureInfo.InvariantCulture)}");

            Console.ReadLine();
            
        }
    }
}
