using AnimalPOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static List<Animal> animais = new List<Animal>();
   
    static void Main(string[] args)
    {
        animais.Add(new Cachorro("lola", 7));
        animais.Add(new Cachorro("betovi", 7));
        animais.Add(new Gato("gato", 7));
        animais.Add(new Gato("farofa", 7));

        foreach(var animal in animais)
        {
            Console.WriteLine($"nome: { animal.Nome}, Idade: {animal.Idade}");
         
            animal.EmitirSom();
        }
    }
}