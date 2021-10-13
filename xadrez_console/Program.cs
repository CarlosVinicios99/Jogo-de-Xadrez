using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez px = new PosicaoXadrez('a', 1);

            Console.WriteLine(px.ToString());
            Console.WriteLine(px.ToPosicao());
        }
    }
}