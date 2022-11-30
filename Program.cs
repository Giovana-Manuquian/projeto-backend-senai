// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Backend_SENAI.classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Giovana";
novaPf.cpf = "12345678975";

// Console.WriteLine(novaPf.nome);
// Console.WriteLine(novaPf.cpf);
Console.WriteLine($"------------------------");


Console.WriteLine($"Nome {novaPf.nome}, CPF: {novaPf.cpf}");
// interpolação

Console.WriteLine("Bem Vindo" + novaPf.nome + ", CPF" + novaPf.cpf + "");
// concatenação
