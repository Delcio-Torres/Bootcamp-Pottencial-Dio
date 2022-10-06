// See https://aka.ms/new-console-template for more information

using Explorando_a_linguagem.Models;


Pessoa p1 = new Pessoa();
p1.Nome = "Delcio";
p1.Sobrenome = "Torres";

Pessoa p2 = new Pessoa();
p2.Nome = "Gabriel";
p2.Sobrenome = "Rodrigues";



Curso cursoIngles = new Curso();
cursoIngles.Nome = "Inglês";
cursoIngles.Alunos = new List<Pessoa>();

cursoIngles.AdicionarAluno(p1);
cursoIngles.AdicionarAluno(p2);
cursoIngles.ListarAlunos();








// Pessoa p1 = new Pessoa();

// Console.Write("Digite seu nome: ");
// p1.Nome = Console.ReadLine();

// Console.Write("Digite seu sobrenome: ");
// p1.Sobrenome = Console.ReadLine();

// Console.Write("Digite sua idade: ");
// p1.Idade = Convert.ToInt32(Console.ReadLine());

// p1.Apresentar();