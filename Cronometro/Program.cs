using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 segundos.");
            Console.WriteLine("M = Minuto => 1m = 1 minuto.");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower(); // Não é feito um parse com isso, até porque ele é string
            char type = char.Parse(data.Substring(data.Length - 1, 1));//15s ou 1234s a gente tem que sempre pegar o último dígito.
            Console.WriteLine(data);
            Console.WriteLine(type);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronometro finalizado...");
            Thread.Sleep(2500);
        }
    }
}