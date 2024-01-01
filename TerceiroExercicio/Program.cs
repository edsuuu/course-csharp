using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma Frase abaixo:");
            string frase = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine($"Voce digitou {frase}");
            Console.WriteLine("");

            Console.WriteLine("Escreva uma cor:");
            string x = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Escreva outra cor:");
            string y = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Escreva mais uma cor:");
            string z = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine($"Você Escreveu as cores {x}, {y} e {z}");
            Console.WriteLine("");

            Console.WriteLine("Escreva 3 Palavras diferentes:");
            string s = Console.ReadLine();
            Console.WriteLine("");

            //Ultilizamos o metodo split para poder capturar varias palavras diferentes apos um espaço e armazenar
            //em um array q apos isso separamos por numeros 0, 1, 2...
            //sempre para definir esse vetor ultlizamos "string[]" veja o exemplo 
            string[] vetor = s.Split(' ');

            string a = vetor[0];
            string b = vetor[1];
            string c = vetor[2];

            Console.WriteLine($"Você escreveu as palavras {a}, {b} e {c} !!");

            Console.ReadLine();
        }
    }
}