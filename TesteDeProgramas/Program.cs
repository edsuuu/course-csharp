using System;

class Calculadora
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Chamando um método que não retorna valor (void)
        MostrarSoma(num1, num2);

        // Chamando um método que retorna valor (int)
        int resultadoSubtracao = CalcularSubtracao(num1, num2);
        Console.WriteLine($"A subtração é: {resultadoSubtracao}");
    }

    // Método que não retorna valor (void)
    static void MostrarSoma(int a, int b)
    {
        int soma = a + b;
        Console.WriteLine($"A soma é: {soma}");
    }

    // Método que retorna valor (int)
    static int CalcularSubtracao(int a, int b)
    {
        int subtracao = a - b;
        return subtracao;
    }
}
