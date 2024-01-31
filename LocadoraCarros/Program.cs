using LocadoraCarros;

decimal precoInicial = 0;
decimal precoHora = 0;


Console.WriteLine("Seja bem vindo ao estacionamento");
Console.WriteLine("--------------------------------");
Console.WriteLine("Digite o Preço Inicial");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o preço por hora");
precoHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(precoInicial, precoHora);


bool menu = true;

while (menu)
{
    Console.Clear();
    Console.WriteLine("Escolha uma opção");
    Console.WriteLine("[1] Adicionar Veiculo");
    Console.WriteLine("[2] Remover");
    Console.WriteLine("[3] Listar Veiculos");
    Console.WriteLine("[0] Sair do Sistema");


    switch (Console.ReadLine())
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;
        case "2":
            estacionamento.RemoverVeiculo();
            break;
        case "3":
            estacionamento.ListarVeiculos();
            break;
        case "0":
            menu = false;
            break;
        default:
            Console.WriteLine("Digite uma opção valida");
            break;
    }

    Console.WriteLine("Digite uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("Encerrando...");