using System;

class somaEmedia 
{
    static void Main()
    {
        float nota = 0;

        Console.WriteLine("quantas notas serão inseridas? (acima de 3 e abaico de 10)? ");
        int tamanho = int.Parse(Console.ReadLine());

        for(int i =1; i<=tamanho; i++)
        {
            Console.WriteLine($"digite a nota {i}");
            nota += float.Parse(Console.ReadLine());
        }

        Console.WriteLine($"o resultado da média é : { nota / tamanho}");

    }


}

