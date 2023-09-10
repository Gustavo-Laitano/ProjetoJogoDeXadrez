using System;
using System.Runtime.CompilerServices;
using tabuleiro;

namespace XadrezConsole
{
    class XadrezConsole
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);
            
            Console.ReadLine();
        }
    }
}