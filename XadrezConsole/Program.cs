using System;
using System.Runtime.CompilerServices;
using tabuleiro;
using xadrez;

namespace XadrezConsole
{
    class XadrezConsole
    {
        static void Main(string[] args)
        {

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
           
        }
    }
}