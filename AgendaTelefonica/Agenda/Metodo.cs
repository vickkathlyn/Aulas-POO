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
            return contato?.Telefone ?? "Contato não encontrado\n";
        }


    }
}
