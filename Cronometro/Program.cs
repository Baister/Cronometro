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
            Console.WriteLine("0s = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower(); // Não é feito um parse com isso, até porque ele é string
            char type = char.Parse(data.Substring(data.Length - 1, 1));//15s ou 1234s a gente tem que sempre pegar o último digito que mostra se vai ser S ou M.
            int time = int.Parse(data.Substring(0, data.Length - 1)); // assim ele vai trazer todos os caracteres menos o "s" ou o "m".
            int multiplier = 1; // Esse é o multiplicador para os minutos.

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            Start(time * multiplier);

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
            Menu();
        }
    }
}