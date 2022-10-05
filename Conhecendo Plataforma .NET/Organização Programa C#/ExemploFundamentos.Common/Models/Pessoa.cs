using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    /// <summary>
    /// Representa o objeto Pessoa
    /// </summary>
    public class Pessoa
    {
         public string Nome { get; set; }
        public int Idade { get; set; }


        /// <summary>
        /// Método para apresentar pessoa 
        /// </summary>
        public void apresenta(){
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos");
        }       
    }
}