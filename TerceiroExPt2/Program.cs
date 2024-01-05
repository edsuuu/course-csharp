using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome e seu Sobrenome: ");
            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];
            string sobrenome = vet[1];

            Console.WriteLine("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos quartos tem na sua Casa: ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sua casa tem {quartos} quartos");

            Console.WriteLine("Digite o preço de um produto: ");
            double produto = double.Parse(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Aqui está o resultado do seu ultimo nome, idade e altura");
            Console.WriteLine(" ");
            Console.Write($"Aqui será o seu sobrenome : {sobrenome}, aqui será dito sua idade q é {idade} e por ultimo sua altura {altura.ToString("F2", CultureInfo.InvariantCulture)}");
        
            Console.ReadLine();

        }
    }
}