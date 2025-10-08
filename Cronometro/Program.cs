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
            int tempoFinal = int.Parse(Console.ReadLine());
            int tempo = 0;
            while (tempo <= tempoFinal)
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
            Console.Clear();
            Console.WriteLine("(x)s = segundos");
            Console.WriteLine("(x)m = minutos");
            Console.WriteLine("Quanto tempo deseja contar?");
            string data = Console.ReadLine().ToLower();
            char tipo = char.Parse(data.Substring(data.Length - 1, 1));
            int tempoFinal = int.Parse(data.Substring(0, data.Length - 1));
            short multiplicador = 1;
            int tempo = 0;
            if (tipo == 'm')
                multiplicador = 60;
            while (tempo <= tempoFinal * multiplicador)
            {
                Console.Clear();
                Console.WriteLine(tempo);
                tempo++;
                Thread.Sleep(1000);
            }
            Console.WriteLine("TRRRRIN!! TRRRRIN!!");
            Console.ReadKey();
            Menu();
        }
        static void TemporizadorCompleto()
        {
            Console.Clear();
            int tempoInicial = int.Parse(Console.ReadLine());
            while (tempoInicial >= 0)
            {
                Console.Clear();
                int hora = tempoInicial / 3600;
                int minuto = tempoInicial % 3600 / 60;
                int segundo = tempoInicial % 60;
                Console.WriteLine($"{hora}:{minuto}:{segundo}");
                tempoInicial--;
                Thread.Sleep(1000);
            }
            Console.WriteLine("TRRRRIN!! TRRRRIN!!");
            Console.ReadKey();
            Menu();

        }
        static void TemporizadorSeg()
        {

        }
        static void Sair()
        {

        }
    }
}
