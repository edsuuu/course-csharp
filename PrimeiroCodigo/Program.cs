﻿using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C;
            
            //Math.Sqrt é ultilizado para calcular a raiz quadrada de algum número
            //Math.Sqrt é para calcular raiz quadrada
            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);

            Console.WriteLine("Raiz quadrade de " + x + " = " + A);
            Console.WriteLine("Raiz quadrade de " + y + " = " + B);
            Console.WriteLine("Raiz quadrade de 25 = " + C);

            //Math.Pow é para numeros elevado por exemplo 3 elevado a 4 
            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);

            Console.WriteLine(x + "elevado a " + y + " = " + A);
            Console.WriteLine(x + "elevado ao quadrado = " + B);
            Console.WriteLine("5 elevando ao quadrado = " + C);

            //abs seria valor absoluto 
            A = Math.Abs(y);
            B = Math.Abs(z);

            Console.WriteLine("Valor absoluto " + y + " = " + A);
            Console.WriteLine("Valor absoluto " + z + " = " + B);

            //para calcular a formula de baskara

            //delta = Math.Pow(b, 2.0) - 4 * a * c;

            //x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            //x1 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.ReadLine();

        }
    }
}