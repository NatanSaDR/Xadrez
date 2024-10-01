using EstudosOOProjetoXadrez.tabuleiro;
using System;
namespace EstudosOOProjetoXadrez
{
    class Program
    {
        static void Main()
        {
            Tabuleiro tab = new Tabuleiro(8,8);

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}