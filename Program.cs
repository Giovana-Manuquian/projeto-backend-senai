// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Backend_SENAI.classes;

Console.Clear();

Utils.BarraCarregamento("Iniciando", 10, ".");

List<PessoaFisica> listaPf = new List<PessoaFisica>();

string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"

***********************************************
|                                             |
|      Bem vindo(a) ao Sistema de Cadastro    |
|        de Pessoas Físicas e Jurídicas.      |
|                                             |
***********************************************
|        Digite o número da opção desejada:   |
***********************************************
|                                             |
|             1 - Pessoa Física               |
|             2 - Pessoa Jurídica             |
|                                             |
|             0 - Sair                        |
***********************************************
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            PessoaFisica metodoPf = new PessoaFisica();

            string? opcaoPf;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
                
***********************************************
|        Digite o número da opção desejada:   |
***********************************************
|                                             |
|         1 - Cadastrar Pessoa Física         |
|         2 - Mostrar Pessoas Físicas         |
|                                             |
|         0 - Voltar ao menu anterior         |
***********************************************
");
                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1":
                        Console.Clear();
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEndPf = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa física que deseja cadastrar");
                        novaPf.nome = Console.ReadLine();

                        bool dataValida;
                        do
                        {
                            Console.WriteLine($"Digite a data de nascimento Ex.: DD/MM/AAAA");
                            string dataNascimento = Console.ReadLine();

                            dataValida = metodoPf.CalcularImposto(dataNascimento);

                            if (dataValida)
                            {
                                novaPf.dataNasc = dataNascimento;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data digitada inválida, por favor digita uma data válida");
                                Console.ResetColor();
                            }

                        } while (dataValida == false);

                        Console.WriteLine($"Digite o número do CPF");
                        novaPf.cpf = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento mensal (apenas números)");
                        novaPf.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro");
                        novoEndPf.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número:");
                        novoEndPf.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento (aperte ENTER para vazio)");
                        novoEndPf.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial? S ou N");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEndPf.endComercial = true;
                        }
                        else
                        {
                            novoEndPf.endComercial = false;
                        }
                        novaPf.endereco = novoEndPf;
                        listaPf.Add(novaPf);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro Realizado com sucesso!");
                        Console.ResetColor();

                        break;

                    case "2":
                        Console.Clear();
                        if (listaPf.Count > 0)
                        {
                            foreach (PessoaFisica cadaPessoa in listaPf)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
                            Nome: {cadaPessoa.nome}
                            Data de Nascimento: {cadaPessoa.dataNasc}
                            CPF: {cadaPessoa.cpf}
                            Rendimento: {cadaPessoa.rendimento.ToString("C")}
                            Logradouro: {cadaPessoa.endereco.logradouro}
                            Numero: {cadaPessoa.endereco.numero}
                            Complemento: {cadaPessoa.endereco.complemento}
                            Endereço Comercial? {((bool)(cadaPessoa.endereco.endComercial) ? "Sim" : "Não")}
                            Taxa de Imposto a ser paga: {metodoPf.CalcularImposto(cadaPessoa.rendimento).ToString("C")}
                    ");
                                Console.WriteLine($"Aperte 'Enter'para continuar...");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Lista Vazia!!!");
                            Thread.Sleep(3000);
                        }
                        break;
                    case "0":
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção Inválida, por favor digite uma outra opção.");
                        Thread.Sleep(3000);
                        break;
                }

            } while (opcaoPf != "0");

            break;

        case "2":
            Console.Clear();
            PessoaJuridica metodoPj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.nome = "Nome PJ";
            novaPj.cnpj = "00.000.000/0001-00";
            novaPj.razaoSocial = "Razao Social Pj";
            novaPj.rendimento = 8000.5f;
            novoEndPj.logradouro = "Rua Niteroi";
            novoEndPj.numero = 180;
            novoEndPj.complemento = "Senai de Informática";
            novoEndPj.endComercial = true;
            novaPj.endereco = novoEndPj;
            Console.WriteLine(@$"
            Nome: {novaPj.nome}
            Razao Social: {novaPj.razaoSocial}
            CNPJ: {novaPj.cnpj}
            Rendimento: {novaPj.rendimento}
            Logradouro: {novaPj.endereco.logradouro}
            Numero: {novaPj.endereco.numero}
            Complemento: {novaPj.endereco.complemento}
            Endereço Comercial? {((bool)(novaPj.endereco.endComercial) ? "Sim" : "Não")}
            CNPJ é valido? {(metodoPj.ValidarCnpj(novaPj.cnpj) ? "Sim" : "Não")}
            Taxa de Imposto a ser paga: {metodoPj.CalcularImposto(novaPj.rendimento).ToString("C")}
            ");
            Console.WriteLine($"Aperte 'ENTER' para continuar");
            Console.ReadLine();
            break;

        case "0":
            Console.WriteLine($"Obrigado(a) por utilizar nosso sistema.");
            BarraCarregamento("Finalizando", 200);
            break;
        default:
            Console.Clear();
            Console.WriteLine($"Opção Inválida, por favor digite outro opção");
            Thread.Sleep(3000);
            break;
    }

} while (opcao != "0");

Utils.BarraCarregamento("Encerrando", 10, ".");

static void BarraCarregamento(string texto, int tempo)
{
    Console.BackgroundColor = ConsoleColor.DarkCyan;
    Console.ForegroundColor = ConsoleColor.Red;

    Console.Write($"{texto}");

    for (var contador = 0; contador < 25; contador++)
    {
        Console.Write(". ");
        Thread.Sleep(tempo);
    }
    Console.ResetColor();
}



// Console.WriteLine($"Nome {novaPf.nome}, CPF: {novaPf.cpf}");
// interpolação

// Console.WriteLine("Bem Vindo" + novaPf.nome + ", CPF" + novaPf.cpf + "");
// concatenação

// C transforma para a moeda do país.

