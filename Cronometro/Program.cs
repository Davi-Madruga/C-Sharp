using System;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }
        static void Start()
        {
                        Console.Clear();
            int tempoInicial = int.Parse(Console.ReadLine());
            int tempo = 0;
            while (tempo <= tempoInicial)
            {
                Console.Clear();
                int hora = tempo / 3600;
                int minuto = tempo % 3600 / 60;
                int segundo = tempo % 60;
                Console.WriteLine($"{hora}:{minuto}:{segundo}");
                tempo++;
            }
        }
    }
}
