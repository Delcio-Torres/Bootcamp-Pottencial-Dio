using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Pessoa
    {
         public string Nome { get; set; }
        public int Idade { get; set; }

        public string apresenta(){
            return $"Meu nome é {Nome} e tenho {Idade} anos";
        }       
    }
}