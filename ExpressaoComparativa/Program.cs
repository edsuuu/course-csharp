using System;

namespace testeComparativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas;


            Console.WriteLine("Que horas são:");

            horas = int.Parse(Console.ReadLine());

            if (horas < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else
            {
                if (horas < 18)
                {
                    Console.WriteLine("boa tarde !");
                }
                else
                {
                    Console.WriteLine("boa noite !");
                }
            }

            Console.ReadLine();
        }
    }


}