internal class Program
{
    private static void Main(string[] args)
    {
        void ExibirMensagensDeBoasVindas()
        {
            Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗░█████╗░███╗░░░███╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔══██╗████╗░████║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░███████║██╔████╔██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══██║██║╚██╔╝██║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗██║░░██║██║░╚═╝░██║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░░░░╚═╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

            Console.WriteLine("\nBem vindo ao scream Sound!");
        }
        void ExibirLogo()
        {
            Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗░█████╗░███╗░░░███╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔══██╗████╗░████║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░███████║██╔████╔██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══██║██║╚██╔╝██║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗██║░░██║██║░╚═╝░██║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░░░░╚═╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
        }

        List<string> ListaBandas = new List<string> { "U2", "The Beatles", "LinkinPark" };

        void exibirOpçoesDoMenu()
        {
            Console.WriteLine("\nDigite 1 para registar uma banda");
            Console.WriteLine("Digite 2 para mostrar todas as bandas");
            Console.WriteLine("Digite 3 para avaliar uma banda");
            Console.WriteLine("Digite 4 para exibir a media de uma banda");
            Console.WriteLine("Digite 5 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolha = Console.ReadLine()!;
            int opcaoConvertida = int.Parse(opcaoEscolha);

            switch (opcaoConvertida)
            {
                case 1:
                    RegistrarBanda();
                    break;
                case 2:
                    Console.WriteLine("Bandas Registradas: \n");
                    MostrarBandasRegistradas();
                    break;
                case 3:
                    Console.WriteLine("Você escolheu a opção 4");
                    break;
                case 4:
                    Console.WriteLine("Você escolheu a opção 4");
                    break;
                case 5:

                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }

        }
        void MostrarBandasRegistradas()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Bandas Registradas");
            foreach (var mostraBandas in ListaBandas)
            {
                Console.WriteLine(mostraBandas);
            }
        }
        void RegistrarBanda()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Registro das Bandas");
            Console.Write("Digite o nome da banda que deseja registrar:");
            var nomeBanda = Console.ReadLine()!;
            ListaBandas.Add(nomeBanda);
            Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso");
            Thread.Sleep(2000);
            Console.Clear();

            ExibirLogo();
            exibirOpçoesDoMenu();
        }
       
        void ExibirTituloDaOpcao(string titulo)
        {
            int quantidadeDeLetras = titulo.Length;
            string asteristicos = string.Empty.PadLeft(quantidadeDeLetras, '*');
            Console.WriteLine(asteristicos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteristicos + "\n");
        }

        ExibirMensagensDeBoasVindas();
        exibirOpçoesDoMenu();
    }
}