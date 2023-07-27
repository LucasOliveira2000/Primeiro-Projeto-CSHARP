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

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();//No código fornecido, os valores são do tipo List<int>, que são listas de inteiros representando avaliações.    
                                                                                        //Dictionary<string, List<int>> indica o tipo do dicionário. Ele é um dicionário que tem chaves do tipo string e valores do tipo List<int>.
bandasRegistradas.Add("Linkin Park", new List<int> {10,8,6 });
bandasRegistradas.Add("The Beatles", new List<int>());
void ExibirLogo() // A void é PascalCase, O void, como mencionado anteriormente, é um tipo de retorno usado para indicar que o método não retorna um valor. 
                   //Ou seja, é utilizado quando o método tem o propósito de executar uma ação ou tarefa,
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

void ExibirMenu() // Criando um função void com o nome "ExibirMenu" onde irei colocaro menu para o usuario escolher qual opção ele quer ir 
{
    ExibirLogo(); // chamo a função
    Console.WriteLine("\nDigite 1 para registrar uma banda"); // printo na tela, somente mostrando ao usuario as opções que ele pode escolher.
    Console.WriteLine("Digite 2 para mostrar todas  as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 5 para sair");
    Console.Write("\nDigite a sua opção: "); // printa na mesma linha para responder com o Console.ReadLine();


    string opcaoEscolhida = Console.ReadLine()!; // Estamos declarando uma variavel "opcaoEscolhida " camelCase e colocamos o tipo de retorno dela para string, onde ao final não queromos que,
                                                // ela seja nula, ai colocamos a ! , o que é necessário para atribuição a uma variável que não é do tipo nullable.
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida); // Quando o usuario escreve na tela no Console.ReadLine()!; a resposta ela vem em string, criamos uma nova variavel
                                                            // declaramos ela int, e colocamos int.Parse que é um método estatico onde convertemos a string em valores numericos.

    switch (opcaoEscolhidaNumerica) // o switch é uma condicional parecida com if e else, e utilizada para trabalhar quando a logica do programa é parecida.
    {
        case 1: // Caso opcaoEscolhidaNumerica seja igual a 1
            RegistrarBanda();
            break; // O break; indica que, após executar o código do case 1, o programa deve sair do switch e continuar a execução a partir da linha seguinte ao switch.

        case 2: // Caso opcaoEscolhidaNumerica seja igual a 2
            MostrarBandasRegistradas();
            break;

        case 3: // Caso opcaoEscolhidaNumerica seja igual a 3
            AvaliarUmaBanda();
            break;

        case 4: // Caso opcaoEscolhidaNumerica seja igual a 4
            ExibirMedia();
            break;

        case 5: // Caso opcaoEscolhidaNumerica seja igual a 5
            Console.WriteLine("Tchau volte sempre (>°__°)> ");
            break;

        default: // Caso opcaoEscolhidaNumerica não seja nenhum dos casos acima (default), É uma forma de garantir que o programa não deixe de responder ou execute comportamentos indesejados quando uma entrada não esperada é recebida.
            Console.WriteLine("Opção inválida!");
            break;

    }
}
void RegistrarBanda() // Chamamos a palavra reservada void para trazer e criar a Função RegistrarBanda para posteriormente chama-la
{
    Console.Clear(); // Limpamos o console
    ExibirTituloDaOpcao("Registro das Bandas"); // chamamos o void com o ExibirTituloDaOpcao
    Console.Write("\nDigite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!; 
    //listaDasBandas.Add(nomeDaBanda);
    bandasRegistradas.Add(nomeDaBanda, new List<int>()); // Chamamos o nosso dicionario e adicionamos com o .Add a variavel do tipo string nomeDaBanda, e adicionamos somente a chave que no caso é o nome da banda.
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

    foreach (string banda in bandasRegistradas.Keys) // Para cada banda dentro de listaDasBandas, foreach (string banda in bandasRegistradas.Keys): Essa é uma estrutura de loop que percorre cada chave (nomes de bandas) no dicionário bandasRegistradas. 
                                                    //O Keys é uma propriedade do dicionário que retorna um conjunto de chaves do dicionário (no caso, os nomes das bandas).
    {
        Console.WriteLine($"Banda: {banda}"); // Printe para mim as bandas

    }

    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu principal");
    Console.ReadKey(); // Console.ReadKey(): Aguarda o usuário pressionar qualquer tecla. A execução do programa é suspensa até que o usuário pressione uma tecla.
    Console.Clear(); //Limpa
    ExibirMenu(); // E chama para mim o Menu
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length; // Calcula a quantidade de letras no título
    string simbolo = string.Empty.PadLeft(quantidadeDeLetras, '*'); // Cria uma string com um símbolo '*' repetido a quantidade de vezes igual à quantidadeDeLetras
    Console.WriteLine(simbolo);  // Imprime o símbolo '*' que delimita o topo do título
    Console.WriteLine(titulo);
    Console.WriteLine(simbolo + "\n");     // Imprime o símbolo '*' que delimita a parte de baixo do título
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
    
    if (bandasRegistradas.ContainsKey(nomeDaBanda)) // Verifica se a banda existe no dicionário bandasRegistradas
    {
        Console.Write($"\nQual a nota que a banda {nomeDaBanda} merece: "); // Se a banda existir, solicita ao usuário que atribua uma nota à banda
        int nota = int.Parse(Console.ReadLine()!); // Lê a nota digitada pelo usuário e a converte para o tipo inteiro.
        bandasRegistradas[nomeDaBanda].Add(nota); // Adiciona a nota à lista de avaliações da banda no dicionário
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}, digite uma tecla para voltar ao menu principal. ");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
    
    else 
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada"); // Caso a banda não exista no dicionário, exibe uma mensagem informando que a banda não foi encontrada
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
    Console.Write("Digite o nome da banda que deseja exibi a média: "); // Solicita ao usuário que digite o nome da banda cuja média deseja exibir
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda)) // Verifica se a banda existe no dicionário bandasRegistradas
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];  // Se a banda existir, obtém a lista de notas da banda, a. List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];: Obtém a lista de notas da banda utilizando o nome da banda como chave para acessar o valor (a lista de notas) no dicionário bandasRegistradas.
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}."); // Calcula e exibe a média das notas da banda usando o método Average() da lista
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
    else 
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada"); // Caso a banda não exista no dicionário, exibe uma mensagem informando que a banda não foi encontrada
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();

    }
    
}


ExibirMenu();








