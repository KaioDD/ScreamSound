using Models;

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

        //List<string> ListaBandas = new List<string> { "U2", "The Beatles", "LinkinPark" };
        Dictionary<string, List<int>> BandasRegistradas= new Dictionary<string, List<int>>();
        BandasRegistradas.Add("LP", new List<int> {10,8,6});
        BandasRegistradas.Add("The Beatles", new List<int> {10,10,10});

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
                    RegistrarBandas();
                    ExibirLogo();
                    exibirOpçoesDoMenu();
                    break;
                case 2:
                    Console.WriteLine("Bandas Registradas: \n");
                    MostrarBandasRegistradas();
                    break;
                case 3:
                    AvaliarUmaBanda();
                    break;
                case 4:
                    CalcularNotaMedia();
                    //exibir a media de uma banda
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
            foreach (var mostraBandas in BandasRegistradas.Keys)
            {
                Console.WriteLine(mostraBandas);
                Thread.Sleep(4000);
                Console.Clear();
                ExibirLogo();
                exibirOpçoesDoMenu();
            }
        }
        void RegistrarBandas()
        {
            Console.Clear();
            Console.WriteLine("Registro de bandas");
            Console.Write("Digite o nome da banda que deseja registrar:");
            var nomeBanda = Console.ReadLine()!;
            //ListaBandas.Add(nomeBanda); refatoração do codigo para adicionar o dictionary
            BandasRegistradas.Add(nomeBanda, new List<int>());
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
        void AvaliarUmaBanda()
        {
            // digite qual banda deseja avaliar
            // se abanda existir >> atribuir uma nota
            // se não existir, retonar ao menu principal

            Console.Clear();
            ExibirLogo();
            ExibirTituloDaOpcao("Avaliar Banda:");
            Console.Write("Qual banda deseja avaliar? ");
            string nomeDaBandaAvaliada = Console.ReadLine()!;

            if (BandasRegistradas.ContainsKey(nomeDaBandaAvaliada))
            {
                Console.Write($"Qual nota a {nomeDaBandaAvaliada} merece: ");
                int nota = int.Parse(Console.ReadLine()!);
                BandasRegistradas[nomeDaBandaAvaliada].Add(nota);
                Console.WriteLine($"A nota {nota} foi resgistrada com sucesso para a banda {nomeDaBandaAvaliada}");
                Thread.Sleep(4000);
                Console.Clear() ;
                ExibirLogo();
                exibirOpçoesDoMenu();


            }
            else
            {
                Console.WriteLine($"A banda {nomeDaBandaAvaliada} não existe");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                ExibirLogo() ;
                exibirOpçoesDoMenu();

            }


        }

        void CalcularNotaMedia()
        {
            Console.Clear();
            ExibirLogo();
            Console.WriteLine("Qual banda deseja ver a media de notas? ");
            string nomeDaBanda = Console.ReadLine()!;
            if (BandasRegistradas.ContainsKey (nomeDaBanda))
            {
                Double mediaBanda = BandasRegistradas[nomeDaBanda].Average()!;
                Console.WriteLine($"A nota da banda {nomeDaBanda} é {mediaBanda}");
            }


        }

        ExibirMensagensDeBoasVindas();
        exibirOpçoesDoMenu();
    }
}