using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    class ContaBancaria
    {

        public ContaBancaria()
        {

        }
        public ContaBancaria(string nome, string rg, string cpf, double conta)
        {
            Nome = nome;
            Rg = rg;
            Cpf = cpf;
            Conta = conta;
        }

        public string Nome { get ; set ; }
        public string Rg { get; set; }
        public string Cpf { get ; set; }
        public double Conta { get ; set; }

        
    }
}
