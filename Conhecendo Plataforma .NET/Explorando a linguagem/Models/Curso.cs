
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
            Console.WriteLine($"Alunos do Curso de {Nome}");
            foreach(Pessoa aluno in Alunos){
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}