class Program
{
    static void Main()
    {
        List<Carro> carros = new List<Carro>();

        // Criamos 1000 carros com cores aleatórias
        for (int i = 0; i < 1000; i++)
        {
            carros.Add(new Carro());
        }

        // Agora, chamamos ExibirCores para exibir a quantidade de carros por cor
        Carro.ExibirCores(); // Chamamos o método estático ExibirCores
    }
} 