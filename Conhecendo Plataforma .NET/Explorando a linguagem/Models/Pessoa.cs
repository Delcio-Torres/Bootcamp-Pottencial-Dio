

namespace Explorando_a_linguagem.Models
{
    public class Pessoa
    {
        //construtor
        public Pessoa(string nome, string sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public Pessoa(){
        }

        private string _nome;
        //private int _idade;
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}";
        public string Nome { get => _nome;
            set{
                if( value == "" ){
                    throw new ArgumentException("Esse campo não pode ser nulo");
                }
                _nome = value;
            } 
        }
        //public int Idade { get; set; }

        public void Apresentar(){
            //Console.WriteLine($"Voce é o {NomeCompleto} e você tem {Idade} anos");
        }
    }
}