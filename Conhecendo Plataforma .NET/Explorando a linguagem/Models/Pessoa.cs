using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Explorando_a_linguagem.Models
{
    public class Pessoa
    {

        private string _nome;
        private int _idade;
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
        public int Idade { get; set; }

        public void Apresentar(){
            Console.WriteLine($"Voce é o {NomeCompleto} e você tem {Idade} anos");
        }
    }
}