// See https://aka.ms/new-console-template for more information

using  ExemploFundamentos.Common.Models;

Pessoa p = new Pessoa();



Console.Write("Qual o seu nome: ");
p.Nome = Console.ReadLine();
Console.Write("Qual a sua idade: ");
p.Idade = int.Parse( Console.ReadLine());
