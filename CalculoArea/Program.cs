using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = 10.0;
            double comprimento = 30.0;

            double metroQuadrado = 200.00;

            double resultado =  area * comprimento;

            double preco = metroQuadrado * comprimento;

            Console.WriteLine($"Resultado: {resultado.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine($"O Preço do terreno é: R$ {preco.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}