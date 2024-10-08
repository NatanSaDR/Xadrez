﻿using EstudosOOProjetoXadrez.tabuleiro;
using EstudosOOProjetoXadrez.xadrez;
using System;
namespace EstudosOOProjetoXadrez
{
    class Program
    {
        static void Main()
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                Tela.imprimirTabuleiro(tab);
                Console.ReadLine();
            }catch(TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}