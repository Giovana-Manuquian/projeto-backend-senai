// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Backend_SENAI.classes;

Console.Clear();

Utils.BarraCarregamento("Iniciando", 10, ".");

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
    Thread.Sleep(1000);

    switch (opcao)
    {
        case "1":

            PessoaFisica novaPf = new PessoaFisica();
            Endereco novoEndPf = new Endereco();

            novaPf.nome = "Giovana";
            novaPf.cpf = "12345678975";
            novaPf.rendimento = 7000.5f;
            novaPf.dataNasc = new DateTime(2000, 01, 01);

            float resultado = novaPf.CalcularImposto(novaPf.rendimento);
            Console.WriteLine(resultado);
            Console.WriteLine($"<----Validação das Datas---->");
            DateTime temp = new DateTime(2000, 01, 01);
            Console.WriteLine(novaPf.ValidarDataNasc("2004/12/08"));

            novoEndPf.logradouro = "Rua Niteroi";
            novoEndPf.numero = 180;
            novoEndPf.complemento = "Predio";
            novoEndPf.endComercial = true;
            novaPf.endereco = novoEndPf;

            Console.WriteLine(@$"
            Nome: {novaPf.nome}
            Endereço: {novaPf.endereco.logradouro}, Número: {novaPf.endereco.numero}
            Maior Idade: {novaPf.ValidarDataNasc(novaPf.dataNasc)}
            ");

            Console.WriteLine($"Para continuar, tecle Enter");
            Console.ReadLine();

            break;

        case "2":

            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.cnpj = "21.137.998./0001-40";
            Console.WriteLine(novaPj.ValidarCnpj("21.137.998./0001-40"));

            Console.WriteLine(@$"
            CNPJ: {novaPj.cnpj}
            Válido: {novaPj.ValidarCnpj(novaPj.cnpj)}
            ");

            novoEndPj.logradouro = "Rua Sergipe";
            novoEndPj.numero = 200;
            novoEndPj.complemento = "Predio";
            novoEndPj.endComercial = true;
            novaPj.endereco = novoEndPj;

            float impostoPagar = novaPj.CalcularImposto(10000.5f);
            Console.WriteLine($"{impostoPagar:0.0}");
            Console.WriteLine($"{impostoPagar.ToString("C")}");

            Console.WriteLine($"Para continuar, tecle Enter");
            Console.ReadLine();

            break;

        case "0":

            Console.WriteLine($"Obrigado(a) por utilizar nosso sistema.");

            break;

        default:

            Console.WriteLine($"A opção selecionada está incorreta, digite um valor indicado");

            break;
    }

} while (opcao != "0");

Utils.BarraCarregamento("Encerrando", 10, ".");



// Console.WriteLine($"Nome {novaPf.nome}, CPF: {novaPf.cpf}");
// interpolação

// Console.WriteLine("Bem Vindo" + novaPf.nome + ", CPF" + novaPf.cpf + "");
// concatenação

// C transforma para a moeda do país.
