using System;
using System.Collections.Generic;
using RPG;

class Program
{
    static List<Personagem> personagens = new List<Personagem>();

    static void Main(string[] args)
    {
        personagens.Add(new Guerreiro("luan", 14,5));
        personagens.Add(new Guerreiro("joao", 10,5));

        personagens.Add(new Arqueiro("Ares", 14, 7, 3));
        personagens.Add(new Arqueiro("sova", 30, 7, 3));

        Personagem.AtacarPersonagem("Ares", "luan", personagens);
        Personagem.AtacarPersonagem("luan", "Ares", personagens);
        Personagem.AtacarPersonagem("Ares", "luan", personagens);
        Personagem.AtacarPersonagem("luan", "Ares", personagens);
    }
}
