using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {


            //faça um programa q recebe 1 numero inteiro e converta em hora, minu e segundos...

            int N, horas, resto, minutos, segundos;

            Console.WriteLine("Digite uma quantidade de segundos: ");
            N = int.Parse(Console.ReadLine());


            //aqui irar fazer a divisao sem mostrar o resto apenas com o valor inteiro...
            horas = N / 3600;
            
            //aqui a % fara a divisao e pegara o resto da conta acima
            resto = N % 3600;

            //apos pegar o resto, a gente vai pegar o valor dele e depois iremos dividir por 60 
            minutos = resto / 60;

            //e após pegaremos o resto da conta acima com a % q dará os segundos 
            segundos = resto % 60;

            Console.WriteLine($" {horas} : {minutos} : {segundos}");

            Console.ReadLine();
        }
    }
}