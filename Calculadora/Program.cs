using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("---CALCULATOR---");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Sair");
            short escolha = short.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Somar();
                    break;
                case 2:
                    Subtrair();
                    break;
                case 3:
                    Multiplicar();
                    break;
                case 4:
                    Dividir();
                    break;
                case 5:
                    Sair();
                    break;
                default:
                    Menu();
                    break;
            }
        }
        static void Somar()
        {
            Console.WriteLine("Digite o primeiro número:");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            float numero2 = float.Parse(Console.ReadLine());
            float resultado = numero1 + numero2;
            Console.WriteLine(numero1 + " + " + numero2 + " = " + resultado);
            Console.ReadKey();
            Menu();
        }
        static void Subtrair()
        {
            Console.WriteLine("Digite o primeiro número:");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            float numero2 = float.Parse(Console.ReadLine());
            float resultado = numero1 - numero2;
            Console.WriteLine(numero1 + " - " + numero2 + " = " + resultado);
            Console.ReadKey();
            Menu();
            
        }
        static void Multiplicar()
        {
            Console.WriteLine("Digite o primeiro número:");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            float numero2 = float.Parse(Console.ReadLine());
            float resultado = numero1 * numero2;
            Console.WriteLine(numero1 + " * " + numero2 + " = " + resultado);
            Console.ReadKey();
            Menu();
            
        }
        static void Dividir()
        {
            Console.WriteLine("Digite o primeiro número:");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            float numero2 = float.Parse(Console.ReadLine());
            float resultado = numero1 / numero2;
            Console.WriteLine(numero1 + " / " + numero2 + " = " + resultado);
            Console.ReadKey();
            Menu();
            
        }
        static void Sair()
        {
            
        }
    }
}
