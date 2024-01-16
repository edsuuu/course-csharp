using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double resultado;

            a = 5;
            b = 2;

            //aqui esta fazendo a divisao inteira entao so iria retornar 2, para poder corrigir a gente acrescenta o double entre () para poder retornar o valor correto 
            //resultado =  a / b ;

            resultado = (double)a / b;

            Console.WriteLine(resultado);

            Console.ReadLine();
        }
    }
}