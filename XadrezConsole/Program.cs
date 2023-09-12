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

            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 2));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 6));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(3, 5));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(3, 6));

                Tela.imprimirTabuleiro(tab);
            }

            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }
    }
}