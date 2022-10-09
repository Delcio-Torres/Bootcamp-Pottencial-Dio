
namespace Explorando_a_linguagem.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }

        public int QuantidadeDeAlunos(){

            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno){

            return Alunos.Remove(aluno);

        }

        public void ListarAlunos(){
            Console.Clear();
            Console.WriteLine($"Alunos do Curso de {Nome}");
            int contador = 1;
            foreach(Pessoa aluno in Alunos){
                Console.WriteLine($"Nº {contador} - {aluno.NomeCompleto}");
                contador++;
            }
            Console.ReadKey();
        }
    }
}