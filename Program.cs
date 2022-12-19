// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Backend_SENAI.classes;

PessoaFisica novaPf = new PessoaFisica();
Endereco novoEndPf = new Endereco();

novaPf.nome = "Giovana";
novaPf.cpf = "12345678975";
novaPf.rendimento = 7000.5f;
novaPf.dataNasc = new DateTime(2000, 01, 01);

Console.WriteLine($"Pessoa Fisica____________________________");
float resultado = novaPf.CalcularImposto(novaPf.rendimento);

Console.WriteLine(resultado);

Console.WriteLine($"Validação das Datas ______________________");
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




// Console.WriteLine(novaPf.nome);
// Console.WriteLine(novaPf.cpf);
// Console.WriteLine($"------------------------");


// Console.WriteLine($"Nome {novaPf.nome}, CPF: {novaPf.cpf}");
// interpolação

// Console.WriteLine("Bem Vindo" + novaPf.nome + ", CPF" + novaPf.cpf + "");
// concatenação

Console.WriteLine($"Pessoa Juridica____________________________");
PessoaJuridica novaPj = new PessoaJuridica();

float impostoPagar = novaPj.CalcularImposto(10000.5f);
Console.WriteLine($"{impostoPagar:0.0}");
Console.WriteLine($"{impostoPagar.ToString("C")}");
// C transforma para a moeda do país.
