using System;
using System.Globalization;
using System.Collections.Generic;
using Tabuleiro;

namespace XadrezConsole
{
    class XadrezConsole
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine("Posição: " + P);

            Console.ReadLine();
        }
    }
}