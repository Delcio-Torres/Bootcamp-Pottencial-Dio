using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace VSCode_Hello_World.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar(){

            Console.WriteLine($"Meu nome é {Nome}, e tenho {Idade} anos.");
        }
    }
}