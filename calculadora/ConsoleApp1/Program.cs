using System;
using System.Security.Cryptography;

class Programa
{
    static void Main()
    {
        Console.WriteLine("Calculadora");
        Console.Write("qual operção você quer fazer? (1= + ,2= - ,3= x ,4= / ) ");
        int operação = int.Parse(Console.ReadLine());

        Console.Write("digite o primeiro numero: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("digite o segundo numero: ");
        int numero2 = int.Parse(Console.ReadLine());



        switch (operação)
        {
            case 1:
                Console.WriteLine($"{numero} + {numero2} = {numero + numero2}");
                break;
            case 2:
                Console.WriteLine($"{numero} - {numero2} = {numero - numero2}");
                break;
            case 3:
                Console.WriteLine($"{numero} x {numero2} = {numero * numero2}");
                break;
            case 4:
                Console.WriteLine($"{numero} / {numero2} = {numero / numero2}");
                break;
          
            default:
                Console.WriteLine("operação invalida");
                break;
        }


      
    }
}
