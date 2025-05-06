using System;
using System.Collections.Generic;
using JogadorInterfaces;

class Program
{
    static void Main(string[] args)
    {
        List<Jogador> jogadores = new List<Jogador>()
        {
            new JogadorFutebol(),
            new JogadorBoliche(),
            new JogadorBasquete()
        };

        foreach (var jogador in jogadores)
        {
           jogador.Jogar();
            Console.WriteLine();
        }

    }
}