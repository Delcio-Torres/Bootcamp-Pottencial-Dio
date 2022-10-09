using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int conta, decimal saldoInicial){
            NumeroConta = conta;
            saldo = saldoInicial;
        }

        public int NumeroConta { get; set; }

        private decimal saldo;

        public void Sacar(decimal valor){

            if (valor > saldo){
                Console.WriteLine("Saldo insuficiente");
            }
            else{
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }
        }

        public void ExibirSaldo(){
            Console.WriteLine($"Saldo atual de: {saldo}");
        }

    }
}