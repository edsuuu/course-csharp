using System;
using System.Globalization;


namespace testeComparativo
{
    class Program
    {
        static void Main(string[] args)
        {

            double notaEdson, notaEdson2, notaLima, notaLima2;

            notaEdson = 45.5;
            notaEdson2 = 31.3;

            notaLima = 34.0;
            notaLima2 = 23.5;

            double aluno1 = notaEdson + notaEdson2;
            double aluno2 = notaLima + notaLima2;

            

            if (aluno1 >= 60.00)
            {
                Console.WriteLine($" O aluno1 foi Aprovado");
                Console.WriteLine($" E a sua nota final foi de {aluno1.ToString("F1", CultureInfo.InvariantCulture)}");

            } else
            {
                Console.WriteLine(" O aluno1 foi Reprovado");
                Console.WriteLine($" E a sua nota final foi de {aluno1.ToString("F1", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine("");

            if (aluno2 >= 60.00)
            {
                Console.WriteLine(" O aluno2 foi Aprovado");
                Console.WriteLine($" E a sua nota final foi de {aluno2.ToString("F1", CultureInfo.InvariantCulture)}");

            }
            else
            {
                Console.WriteLine(" O aluno2 foi Reprovado");
                Console.WriteLine($" E a sua nota final foi de {aluno2.ToString("F1", CultureInfo.InvariantCulture)}");
            }

            Console.ReadLine();

        }
    }
}