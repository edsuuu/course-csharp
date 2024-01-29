using System;
using System.Globalization;

namespace formula
{
	class Course
	{
		static void Main(string[] args)
		{
			double a, b, c, delta, r1, r2;


			Console.WriteLine("Digite os Valores separados por espaço: a b c ");
			String[] vet = Console.ReadLine().Split(' ');

			//Console.WriteLine("Digite o numero de A: ");
			a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            //Console.WriteLine("Digite o numero de B: ");
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            //Console.WriteLine("Digite o numero de C: ");
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);
			Console.WriteLine("");

			delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (a == 0 || delta < 0.0)
			{
				Console.WriteLine("Impossivel Calcular");
			} else
			{
				r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

				Console.WriteLine($"R1 = {r1.ToString("F5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"R2 = {r2.ToString("F5", CultureInfo.InvariantCulture)}");
            }

			Console.ReadLine();
		}
	}
}