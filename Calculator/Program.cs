using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

            // System.Console.WriteLine("SOMAR: ");
            // Somar();

            // System.Console.WriteLine("SUBTRAÇÃO: ");
            // Subtracao();

            // System.Console.WriteLine("DIVISÃO: ");
            // Divisao();

            // System.Console.WriteLine("MULTIPLICAÇÃO: ");
            // Multiplicacao();
        }

        static void Menu()
        {
            Console.Clear();

            System.Console.WriteLine("O que deseja fazer?");
            System.Console.WriteLine("---");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("1- SOMAR");
            System.Console.WriteLine("2- SUBTRAIR");
            System.Console.WriteLine("3- DIVIDIR");
            System.Console.WriteLine("4- MULTIPLICAR");
            System.Console.WriteLine("5- Sair da Aplicação");

            System.Console.WriteLine("------------");

            System.Console.WriteLine("Selecione a opção desejada: ");
            short opcaoMenu = short.Parse(Console.ReadLine());

            switch (opcaoMenu)
            {
                case 1: Somar(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Somar()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine();
            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            //System.Console.WriteLine(valor1);
            //System.Console.WriteLine(valor2);
            System.Console.WriteLine("");

            float resultado = valor1 + valor2;

            // Concatenação (Exemplo)
            // System.Console.WriteLine("O resultado da Soma é " + resultado);

            // $ = Interpolação de concatenação (Exemplos)
            // System.Console.WriteLine($"Os valores são {valor1} (+) {valor2}.");

            System.Console.WriteLine($"O resultado da Soma é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine();
            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            //System.Console.WriteLine(valor1);
            //System.Console.WriteLine(valor2);
            System.Console.WriteLine("");

            float resultado = valor1 - valor2;

            // Concatenação (Exemplo)
            // System.Console.WriteLine("O resultado da Subtração é " + resultado);

            // $ = Interpolação de concatenação (Exemplos)
            // System.Console.WriteLine($"Os valores são {valor1} (-) {valor2}.");

            System.Console.WriteLine($"O resultado da Subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine();
            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            //System.Console.WriteLine(valor1);
            //System.Console.WriteLine(valor2);
            System.Console.WriteLine("");

            float resultado = valor1 / valor2;

            // Concatenação (Exemplo)
            // System.Console.WriteLine("O resultado da Divisão é " + resultado);

            // $ = Interpolação de concatenação (Exemplos)
            // System.Console.WriteLine($"Os valores são {valor1} (/) {valor2}.");

            System.Console.WriteLine($"O resultado da Divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine();
            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            //System.Console.WriteLine(valor1);
            //System.Console.WriteLine(valor2);
            System.Console.WriteLine("");

            float resultado = valor1 * valor2;

            // Concatenação (Exemplo)
            // System.Console.WriteLine("O resultado da Multiplicação é " + resultado);

            // $ = Interpolação de concatenação (Exemplos)
            // System.Console.WriteLine($"Os valores são {valor1} (*) {valor2}.");

            System.Console.WriteLine($"O resultado da Multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}
