using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x, y;
            //int x;
            //double y;

            //x = 5;

            //y = 6 * x;

            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //double b, B, h, area;

            //b = 6.0;
            //B = 8.0;
            //h = 5.0;

            //area = (b + B) / 2.0 * h;

            //Console.WriteLine(area);

            int a , b ;
            double resultado;

            a = 5;
            b = 2;

            //aqui esta fazendo a divisao inteira entao so iria retornar 2, para poder corrigir a gente acrescenta o double entre () para poder retornar o valor correto 
            //resultado =  a / b ;

            resultado = (double)  a / b ;

            Console.WriteLine(resultado);

            //outro exemplo 

            int A;
            double B;

            A = 5.0
            B = A;

            Console.WriteLine(B);

            //nao é possivel converver o tipo double para int pois pode ocorrer perda de informação

            //num int 5; num double 5.0 

            Console.ReadLine();
        }
    }
}