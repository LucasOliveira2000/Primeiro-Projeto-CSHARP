// Screen Sound
//C# linguagem fortamente tipada
//Camelcase = A variavel sempre começa minisculo
//Depois que escolher a variavel sempre tem que chama-la
//criar uma função "void" para reaproveitar codigo e chamalo novamente outra vez.
//Na nomenclatura das funções utilizamos o padrão PascalCase que é adotado pelo iniciu em maiusculo
//O @ no começo se chama verbatim L, do jeito que você que a string, ela vai aparecer!
//Sempre que tiver uma função " void " tem que chamar ela em baixo para aparecer
//Console.ReadLine(); é como se fosse um input, onde aparece um espaço para o usuario digitar algo
//Para a resposta do usuario vir em string e não nula, tem que colocar a ! antes do ponto e virgula
// para a string de valores numerios vir em inteiro, temos que chamar ela em int e depois chamar o int.Parse e selecionar a variavel que queremos que fique em inteiro.
// O switch case é usado para quando se tem varias condições que estão interligadas por uma logica, é usado em vez do if e else if
// default é chamado como se fosse um Else, caso o usuario digitar algo ou escrever algo que não tenha nas opções, ele sair do menu.
//Console Write é para o usuario digitar na mesma linha o WriteLine é na de baixo
//O format do python aqui é um sifrão $, passa ele  antes das aspas e depois define dentro das {} a variavel.

using System;

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

//List<string> listaDasBandas = new List<string> {"Slipknot", "The Beatles", "Calypson" };   

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> {10,8,6 });
bandasRegistradas.Add("The Beatles", new List<int>());
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

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas  as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 5 para sair");
    Console.Write("\nDigite a sua opção: ");


    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida); //convertendo opcaoEscolhida para inteiro

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;

        case 2:
            MostrarBandasRegistradas();
            break;

        case 3:
            AvaliarUmaBanda();
            break;

        case 4:
            ExibirMedia();
            break;

        case 5:
            Console.WriteLine("Tchau volte sempre (>°__°)> ");
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;

    }
}
void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das Bandas");
    Console.Write("\nDigite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    //listaDasBandas.Add(nomeDaBanda);
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"\nA Banda {nomeDaBanda} foi registrada, aperte qualquer tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    //for (int i = 0; i < listaDasBandas.Count; i++) // Conta todas as bandas e enquanto eu tiver banda vou contando
    //{
        //Console.WriteLine($"Bandas: {listaDasBandas[i]}");
    //}

    foreach (string banda in bandasRegistradas.Keys) // Para cada banda dentro de listaDasBandas
    {
        Console.WriteLine($"Banda: {banda}"); // Printe para mim as bandas

    }

    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu principal");
    Console.ReadKey(); // Qualquer tecla que for digitada ele vai me retornar para o menu principal
    Console.Clear(); //Limpa
    ExibirMenu(); // E chama para mim o Menu
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string simbolo = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(simbolo);
    Console.WriteLine(titulo);
    Console.WriteLine(simbolo + "\n");
}


void AvaliarUmaBanda()
{
    //digite qual banda deseja avaliar
    //se a banda existir no diciionario >> atribuir uma nota
    //se não, volta ao menu

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"\nQual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}, digite uma tecla para voltar ao menu principal. ");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
    
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }


}

void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média da banda");
    Console.Write("Digite o nome da banda que deseja exibi a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}."); //Average tira a média das notas
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();

    }
    
}


ExibirMenu();








