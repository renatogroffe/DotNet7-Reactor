using ExemploRawStringLiterals;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;

Console.WriteLine("***** Testes com C# 11 | Raw String Literals *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName}- Kernel: {Environment
    .OSVersion.VersionString}");

var pessoa1 = "{ \"Nome\": \"Renato Groffe\", \"Cidade\": \"Sao Paulo\", \"Idade\": 40 }";
Teste.ExibirConteudo(pessoa1);

var pessoa2 = """{ "Nome": "Joao Oliveira", "Cidade": "Rio de Janeiro", "Idade": 20 }""";
Teste.ExibirConteudo(pessoa2);

var pessoa3 =
    """
       {
         "Nome": "Maria da Silva",
         "Cidade": "Belo Horizonte",
         "Idade": 32
       }
    """;
Teste.ExibirConteudo(pessoa3);