using System;
using System.Collections.Generic;
using ConsoleApp1;

class Program
{
    static void Main()
    {
        Cachorro dog = new Cachorro("lola","feminino","pincher");
        Gato cat = new Gato("Ana", "femino", "branco");
        Passaro bird = new Passaro("josé", "masculino", "papagaio");
        Peixe fish = new Peixe("bolhinha", "masculino", "sardinha");

        List<Animal> Animais = new List<Animal>();

        Animais.Add(dog);
        Animais.Add(cat);
        Animais.Add(bird);
        Animais.Add(fish);

        foreach(Animal animal in Animais)
        {
            Console.WriteLine($"Nome: {animal.Nome}, Sexo: {animal.Sexo}, Raça: {animal.Raca}");
            animal.EmitirSom();
        }
    }
}