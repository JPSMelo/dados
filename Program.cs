bool voltarMenu1;

do
{
    voltarMenu1 = false;
    Jogador jogador1 = new Jogador();
    int menu1, dadoJogador, dadoCPU;
    double valor, valorAposta;
 
    Console.Clear();
    Console.WriteLine("Joguinho dos dados");
    Console.WriteLine("Jogador -> " + jogador1.nome);
    Console.WriteLine("Saldo -> R$ "+ jogador1.saldo );

    Console.WriteLine("-------------------------------------");
    Console.WriteLine("Selecione uma das opções a seguir:");
    Console.WriteLine();
    Console.WriteLine("1 - Jogar");
    Console.WriteLine("2 - Depositar saldo em conta");
    Console.WriteLine("3 - Cadastrar Jogador");
    Console.WriteLine();
    Console.Write("Sua escolha [1-3] -> ");
    
    menu1 = Int32.Parse(Console.ReadLine());

    switch (menu1)
    {
        case 1:
            Random rodarDado = new Random();
            dadoCPU = rodarDado.Next(1,6);
            Console.Clear();
            Console.Write("Selecione o valor que você deseja apostar -> ");
            valorAposta = Double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Selecione o valor do dado [1-6] -> ");
            dadoJogador = Int32.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Valor do dado rodado -> " + dadoCPU);
            Console.WriteLine("Valor apostado do dado -> " + dadoJogador);
            if (dadoJogador == dadoCPU)
            {
                Console.WriteLine("Você venceu o dado. :D");
                jogador1.Depositar(valorAposta * 2);
            }
            else
            {
                Console.WriteLine("Você perdeu para o dado. :(");
                jogador1.Debitar(valorAposta);
            }
            Console.WriteLine();
            Console.WriteLine("Seu saldo atual é de -> " + jogador1.saldo + "R$");
            Console.WriteLine();
            Console.WriteLine("Digite qualquer tecla para continuar...");
            Console.ReadLine();
            voltarMenu1 = true;
            break;
        
        case 2:
            Console.Clear();
            Console.WriteLine("Depósito de valor em conta");
            Console.WriteLine("---------------------");
            Console.Write("Digite o valor a ser depositado: ");
            valor = Double.Parse(Console.ReadLine());
            jogador1.Depositar(valor);
            Console.WriteLine("Depósito concluído, digite qualquer tecla para continuar...");
            Console.ReadLine();
            voltarMenu1 = true;
            break;

        case 3:
            Console.Clear();
            Console.WriteLine("Cadastro de Jogador");
            Console.WriteLine("---------------------");
            Console.Write("Digite o nome do jogador: ");
            jogador1.nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Digite o CPF do jogador: ");
            jogador1.cpf = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Cadastro concluído, digite qualquer tecla para continuar...");
            Console.ReadLine();
            voltarMenu1 = true;
            break;

        default:
            voltarMenu1 = true;
            break;
    }

} while (voltarMenu1);
