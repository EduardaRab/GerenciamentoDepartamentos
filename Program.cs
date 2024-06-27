string mensagem = "Bem-vindo ao gerenciador de departamentos!";
List<string> departamentos = new List<string>(); // criando uma lista

void ExibirMensagemBemVindo()
{
    Console.WriteLine(@"𝔾𝕖𝕣𝕖𝕟𝕔𝕚𝕒𝕕𝕠𝕣 𝕕𝕖 𝔻𝕖𝕡𝕒𝕣𝕥𝕒𝕞𝕖𝕟𝕥𝕠𝕤"); // atalho "cw"
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("\n\n"+mensagem+"\n\n");
    Console.WriteLine("--------------------------------------------------");
}

void ExibirMenu()
{
    // o @ substitui as aspas triplas
    Console.WriteLine(@"
    [1] para cadastrar um departamento
    [2] para mostrar todos os departamentos
    [3] para avaliar um departamento
    [4] para exibir a média de um departamento
    [0] para sair
");
}

void RegistrarDepartamento()
{
    Console.Clear(); //limpa o terminal
    Console.WriteLine("Registro de Departamentos"); //pula para a próxima linha
    Console.Write("Digite o nome do departamento: "); //fica na mesma linha
    string nomeDepartamento = Console.ReadLine();
    departamentos.Add(nomeDepartamento); // salvando na lista
    Console.WriteLine($"O departamento {nomeDepartamento} foi registrado!"); //colocar variáveis no meio da string
    Thread.Sleep(2000); //espera um tempo
    Console.Clear();
    ExibirMensagemBemVindo();
    ExibirMenu();
}

void ExibirDepartamentosRegistrados()
{
    Console.Clear();
    Console.WriteLine("Departamentos cadastrados:");
    foreach(var departamento in departamentos)
    {
        Console.WriteLine($"Departamento: {departamento}\n");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}

ExibirMensagemBemVindo();
ExibirMenu();

string opcaoEscolhida = Console.ReadLine(); //lendo as informações digitas no console
int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

switch (opcaoEscolhidaNumerica)
{
    case 1: RegistrarDepartamento(); break;
    case 2: ExibirDepartamentosRegistrados(); break;
    case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica); break;
    case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica); break;
    case 0: Console.WriteLine("Você escolheu a opção  " + opcaoEscolhidaNumerica); break;
    default: Console.WriteLine("Opção inválida"); break;
}