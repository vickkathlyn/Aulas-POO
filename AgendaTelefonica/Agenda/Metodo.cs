using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{   
    public class Metodo
    {
        private List<Contato> contatos;

        public Metodo() 
        {
            contatos = new List<Contato>();
        }

        public void AdicionarContato()
        {
            Console.WriteLine("Digite o nome do contato:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o e-mail do contato:");
            string email = Console.ReadLine();

            Console.WriteLine("Digite o telefone do contato:");
            string telefone = Console.ReadLine();

            Contato novoContato = new Contato(nome, telefone, email);
            contatos.Add(novoContato);
            Console.WriteLine($"Contato {nome} adicionado com sucesso!\n ");
        }
        public string BuscarContato(string nome)
        {
            Console.WriteLine($"Buscando por: '{nome}'");
            var contato = contatos.Find(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            return contato?.Telefone + "\n" ?? "Contato não encontrado\n";
        }

        public void RemoverContato(string nome)
        {
            var contato = contatos.Find(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (contato != null)
            {
                contatos.Remove(contato);
                Console.WriteLine($"Contato {nome} removido com sucesso.\n");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.\n");
            }


        }

        public void AlterarContato(string nome)
        {
            var contato = contatos.Find(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (contato != null)
            {
                Console.WriteLine("Contato encontrado. Digite os novos dados:");

                Console.Write("Novo nome (ou pressione Enter para manter o atual): ");
                string novoNome = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(novoNome))
                {
                    contato.Nome = novoNome;
                }

                Console.Write("Novo e-mail (ou pressione Enter para manter o atual): ");
                string novoEmail = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(novoEmail))
                {
                    contato.Email = novoEmail;
                }

                Console.Write("Novo telefone (ou pressione Enter para manter o atual): ");
                string novoTelefone = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(novoTelefone))
                {
                    contato.Telefone = novoTelefone;
                }

                Console.WriteLine("Contato atualizado com sucesso!\n");
            }
            else
            {
                Console.WriteLine("Contato não encontrado.\n");
            }
        }


    }
}
