using System;
using System.Globalization;

namespace MyNamespace
{
	class MyClass
	{
		static void Main(string[] args)
		{
			int minutos;
			double conta; 

			Console.WriteLine("Quantos Minutos foi Ultilizado ?");
			minutos = int.Parse(Console.ReadLine());

			conta = 50.0;

			if (minutos > 100) {
				conta += (minutos - 100) * 2.0; 
				
			}
			Console.WriteLine($"O valor da conta é R$ {conta.ToString("F2", CultureInfo.InvariantCulture)}");

			Console.ReadLine();

        }
	}
}