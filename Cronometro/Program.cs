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
            Console.WriteLine("---Relógio---");
            Console.WriteLine("1 - Cronometro Completo");
            Console.WriteLine("2 - Cronometro Seg ou Min");
            Console.WriteLine("3 - Temporizador Completo");
            Console.WriteLine("4 - Temporizador Seg ou Min");
            Console.WriteLine("5 - Sair");
            short escolha = short.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    CronometroCompleto();
                    break;
                case 2:
                    CronometroSeg();
                    break;
                case 3:
                    TemporizadorCompleto();
                    break;
                case 4:
                    TemporizadorSeg();
                    break;
                case 5:
                    Sair();
                    break;
            }
        }
        static void CronometroCompleto()
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
                Thread.Sleep(1000);
            }
            Console.WriteLine("TRRRRIN!! TRRRRIN!!");
            Console.ReadKey();
            Menu();
        }
        static void CronometroSeg()
        {

        }
        static void TemporizadorCompleto()
        {

        }
        static void TemporizadorSeg()
        {

        }
        static void Sair()
        {

        }
    }
}
