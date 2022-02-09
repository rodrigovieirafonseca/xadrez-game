using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(9, 0));
                tab.colocarPeca(new Rei(Cor.Preta, tab), new Posicao(2, 0));
                tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));

                Tela.ImprimirTabuleiro(tab);
            }
            catch(TabuleiroExption e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}