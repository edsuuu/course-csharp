using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Idade : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite uma letra");
            char letra = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura:");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite seu nome, sexo, idade e altura");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura2 = double.Parse(vet[3], CultureInfo.InvariantCulture);


            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(letra);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(nome, sexo , idade, altura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura2.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}