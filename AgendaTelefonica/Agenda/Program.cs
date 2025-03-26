using System;
using System.Collections.Generic;
using Agenda;

class Program
{
    static void Main()
    {
        int opcao;  // Declarar como inteiro
        string entrada;
        string BuscContato;
        Metodo metodo = new Metodo();
        // List<Contato> agenda = new List<Contato>();

        do
        {
            Console.WriteLine("----- Qual serviço gostaria de realizar? -----\n");
            Console.WriteLine("1 - Adicionar contato\n");
            Console.WriteLine("2 - Remover contato\n");
            Console.WriteLine("3 - Buscar contato\n");
            Console.WriteLine("4 - Alterar dados de um contato\n");
            Console.WriteLine("Se deseja encerrar o atendimento, digite qualquer tecla\n");

            entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcao))
            {
                Environment.Exit(0);  // Encerra o programa
            }

            opcao = int.Parse(entrada);

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("----- Cadastro de Contato -----\n");

                    metodo.AdicionarContato();

                
                    

                    break;
                case 3:

                    Console.WriteLine("----- Buscar Contato -----\n");
                    Console.WriteLine("digite o nome do contato que deseja buscar: ");
                    BuscContato = Console.ReadLine();
                    Console.WriteLine(metodo.BuscarContato(BuscContato));


                    break;

                case 2:

                    Console.WriteLine("----- Remover Contato -----\n");
                    Console.WriteLine("digite o nome do contato que vc deseja remover: ");
                    BuscContato= Console.ReadLine();
                    metodo.RemoverContato(BuscContato);

                    break;

                case 4:
                    Console.WriteLine("----- Alterar Contato -----\n");
                    Console.WriteLine("Digite o nome do contato: ");
                    BuscContato = Console.ReadLine();
                    metodo.AlterarContato(BuscContato);
                break;
            }

        } while (opcao >= 1 && opcao <= 4);  // Aqui está a chave faltando
    }
}
