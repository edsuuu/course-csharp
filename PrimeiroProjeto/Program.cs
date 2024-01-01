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
            //para definir casas decimais a gente ultiliza o toSTRING(F2) O 2 seria quantas casas decimais eu iria querer
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));

            //para usar o culture precisa definir o using system.globalization la em cima do codigo q seria uma biblioteca 
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            //tem duas maneiras de concatenar uma é usando o $ na frente e para variaveis usar as chaves 

            Console.WriteLine($"A idade dessa pessoa é {idade} e tem altura de {altura} é do sexo {sexo}");
            //a outra é concatenar com os + 

            Console.WriteLine($"A idade dessa pessoa é " + idade + " e tem altura de " + altura + " e é do sexo " + sexo);

            Console.WriteLine("writeline é para quebra de linha");
            Console.Write("write é para n ter quebra de linha");
            Console.Write(", iria pegar sequencia assim");
            //Console.ReadKey();
            Console.ReadLine();
        }
    }
}