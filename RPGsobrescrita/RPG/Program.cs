using System;
using System.Collections.Generic;
using RPG;

class Program
{
    static List<Personagem> personagens = new List<Personagem>();

    static void Main(string[] args)
    {
        personagens.Add(new Guerreiro("luan", 30));
        personagens.Add(new Guerreiro("joao", 10));

        personagens[0].Atacar("luan", "joao", personagens);
    }
}
