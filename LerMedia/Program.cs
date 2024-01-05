using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
          
           
            Console.WriteLine("Digite o nome e a idade da primeira pessoa: ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome1 = vet[0];
            int idade1 = vet[1];

            Console.WriteLine("Digite o nome e a idade da proxima pessoa: ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome2 = vet[0];
            int idade2 = vet[1];

            Console.WriteLine("Agora iremos calcular a media da idade das duas Pessoas: ");

           double media = (double) (idade1 + idade2) / 2;

            Console.WriteLine("A media das idades é: " + media.ToString("F1"));
            
        }
    }
}