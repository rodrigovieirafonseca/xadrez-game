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
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while(!partida.terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.tab);
                        Console.WriteLine();
                        Console.WriteLine("Turno: " + partida.turno);
                        Console.WriteLine("Aguardando Jogada do: " + partida.jogadorAtual);

                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.WriteLine("Turno: " + partida.turno);
                        Console.WriteLine("Aguardando Jogada do: " + partida.jogadorAtual);
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.valorPosicaoDeDestino(origem, destino);

                        partida.executaJogada(origem, destino);
                    }
                    catch(TabuleiroExption e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                
            }
            catch(TabuleiroExption e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}