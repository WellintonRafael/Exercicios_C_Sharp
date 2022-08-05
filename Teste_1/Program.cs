// See https://aka.ms/new-console-template for more information

class Program
{
    static List<Carro> list = new List<Carro>(3);
    static void Main (string[] args)
    {
        TestandoCores();
       
    }

    static void TestandoCores()
    {
        Console.WriteLine("Digite o nome da cor 'Verde'... Só ela funciona: ");
        string nomeDaVariavel = Console.ReadLine();
        bool parsed = Enum.TryParse(nomeDaVariavel, true, out CoresOuCor cor);
        if (!parsed) return;

        switch (cor) {
            case CoresOuCor.Verde:
                Console.WriteLine("Verde é feio!");
                break;
            case CoresOuCor.Azul:
                Console.WriteLine("Azul é feio!");
                break;
            case CoresOuCor.Unicórnio:
                Console.WriteLine("Unicórnio é de princesas!");
                break;
        }
    }

    static void Funcao()
    {
        Console.WriteLine("Digite 1 para adicionar um novo carro. Ou 2 para listá-los: ");
        ConsoleKeyInfo Key = Console.ReadKey();
        Console.Clear();
        switch (Key.KeyChar)
        {
            case '1':
                Console.WriteLine("Digite o nome do carro: ");
                string nomeDoCarro = Console.ReadLine();

                Console.WriteLine("Força do carro: ");
                int horsePower = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Preço de venda: ");
                float preco = Convert.ToSingle(Console.ReadLine());

                Carro carro = new Carro (nomeDoCarro, horsePower, preco);
                list.Add(carro);


                break;
            case '2':

                foreach (Carro car in list) {
                    Console.WriteLine(car.name);
                    Console.WriteLine(car.horsePower);
                    Console.WriteLine(car.price);

                }


                break;
        }
        Funcao();

    }
}

