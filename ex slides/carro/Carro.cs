using System;
using System.Collections.Generic;

class Carro
{
    // Contadores estáticos para as cores
    private static int vermelho = 0;
    private static int azul = 0;
    private static int amarelo = 0;

    private static Random random = new Random();

    public string Cor { get; set; }

    public Carro()
    {
        List<string> cores = new List<string> { "vermelho", "azul", "amarelo" };
        Cor = cores[random.Next(cores.Count)];

        // Incrementa o contador da cor correspondente
        if (Cor == "vermelho")
        {
            vermelho++;
        }
        else if (Cor == "azul")
        {
            azul++;
        }
        else
        {
            amarelo++;
        }
    }

    // Método estático para exibir a quantidade de carros de cada cor
    public static void ExibirCores()
    {
        Console.WriteLine($"Existem {vermelho} Carros da cor vermelha");
        Console.WriteLine($"Existem {azul} Carros da cor azul");
        Console.WriteLine($"Existem {amarelo} Carros da cor amarela");
    }
}