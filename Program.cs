using System;

namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero1, numero2, numero3;

            Console.WriteLine(" ");
            Console.WriteLine("Bem vindo usuário!");
            Console.WriteLine(" ");
            Console.Write(@"Esse programa exibirá o resultado do 
cálculo da media aritmética entre 3 números reais digitados por ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("você!");
            Console.ResetColor();
            Console.WriteLine(" ");

            Console.Write("Digite o primeiro número: ");
            numero1 = Console.ReadLine();
            Console.Write("Digite o segundo número: ");
            numero2 = Console.ReadLine();
            Console.Write("Digite o terceiro número: ");
            numero3 = Console.ReadLine();
            Console.WriteLine(" ");
            
            double nr1 = Convert.ToDouble(numero1);
            double nr2 = Convert.ToDouble(numero2);
            double nr3 = Convert.ToDouble(numero3);

            double media = (nr1 + nr2 + nr3) / 2;

            Console.Write($"Média: {media}");

        }
    }
}
