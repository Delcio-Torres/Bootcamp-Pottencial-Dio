// See https://aka.ms/new-console-template for more information

using Explorando_a_linguagem.Models;

Pessoa p1 = new Pessoa();

Console.Write("Digite seu nome: ");
p1.Nome = Console.ReadLine();

Console.Write("Digite sua idade: ");
p1.Idade = Convert.ToInt32(Console.ReadLine());

p1.Apresentar();


string[] numero1 = new string[1];
string[] numero2 = new string[1];

numero1[0] = "4563";
numero2[0] = "2563456";

if(numero2[0].Contains(numero1[0])){
    Console.WriteLine("Encaixa");
}
else{
    Console.WriteLine("Nao encaixa");
}

