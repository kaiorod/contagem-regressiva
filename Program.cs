using System;

namespace contagem_regressiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nPreparar...");
            Console.ReadKey();
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nApontar...");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nFOGO !");
            Console.WriteLine();

            Console.ResetColor();
        }
    }
}
