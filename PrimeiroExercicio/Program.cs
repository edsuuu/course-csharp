//Calcule a area de um terreto e o preço 

using System;
using System.Globalization;

namespace course
{
    class Program
    {
        static void Main(string[] args)
        {
            //definições de variaveis
            double largura, comprimento, precoMetroQuadrado, area, preco;

            //atribuições a variaveis 
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //pode ser escrita assim : double area = "vai fazer isso"; 
            //ou como os exemplos abaixo 

            area = largura * comprimento;
            preco = area * precoMetroQuadrado;


            //para concatenar ultilizamos o + entre uma string e variavel 
            Console.WriteLine("Area = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Preço = " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}