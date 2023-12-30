using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Toda sintaxe de definição de variavel funciona com 
            //<tipo da variavel> <nome da vriavel> = <valor da variavel>

            //Para valores inteiros usar int
            int idade = 25;

            //Para valores quebrados usamos double
            double altura = 1.75;
            
            //Para valores de 1 caracter usamos char
            char sexo = 'M';

            double x = 10.35784;

            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));



            Console.WriteLine($"A idade dessa pessoa é {idade} e tem altura de {altura} é do sexo {sexo}");


            Console.WriteLine("Hello World!");
            Console.Write("para n ter quebra de tinha");
            //Console.ReadKey();
            Console.ReadLine();
        }
    }
}