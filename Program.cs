//Screen Sound
String mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int>{10, 8, 6});
bandasRegistradas.Add("The Beatles", new List<int>());

// List<String> listaDasBandas = new List<string>();

void ExibirLogo()
{
    Console.WriteLine(@"
    
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu ()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda.");
    Console.WriteLine("Digite 2 para mostrar todas as bandas.");
    Console.WriteLine("Digite 3 para avaliar uma banda.");
    Console.WriteLine("Digite 4 para exibir a média de uma banda.");
    Console.WriteLine("Digite -1 para sair.");

    Console.Write("\nDigite a sua opção: ");
    String opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: ExibirMediaBanda();
            break;
        case -1: Console.WriteLine("Tchau tchau :)");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    String nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

    if (bandasRegistradas.Count == 0)
    {
        Console.WriteLine("Nenhuma banda registrada.");
        
        ExibirOpcoesDoMenu();
    }
    else
    {
       /* for (int i = 0; i < listaDasBandas.Count; i++)
        {
            Console.WriteLine($"Banda: {listaDasBandas[i]}");
        } */

        foreach (String banda in  bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

// Função para exibir o título da opção com asteriscos acima e abaixo
void ExibirTituloDaOpcao(string titulo){
    int quantidadeDeLetras = titulo.Length;
    String asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');

    // Imprime os asteriscos acima do título
    Console.WriteLine(asteriscos);

    // Imprime o título
    Console.WriteLine(titulo);

    // Imprime os asteriscos abaixo do título
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    //Digitar a banda que deseja avaliar
    //Se a banda existir no dicionário >> atribuir uma nota
    //Se não volta para o Menu principal
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    String nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMediaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir Média de uma banda");
    Console.Write("Digite o nome da banda que deseja exibir a média: ");
    String nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notas = bandasRegistradas[nomeDaBanda]; // Obtém a lista de notas da banda
        double mediaBanda = notas.Average();
        Console.WriteLine($"\nA média para a banda {nomeDaBanda} é {mediaBanda:f2}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else {

        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }

}

ExibirOpcoesDoMenu();
