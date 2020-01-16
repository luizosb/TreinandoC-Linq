using System;
using System.Collections.Generic;
using System.Linq;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria p1 = new ContaBancaria("Luiz", "123456789", "987654321", 5000.00);
            ContaBancaria p2 = new ContaBancaria("Italo", "123456798", "985437621", 5500.00);
            ContaBancaria p3 = new ContaBancaria("Gustavo", "123789456", "984321765", 6000.00);
            ContaBancaria p4 = new ContaBancaria("Juliana", "345126789", "984321765", 6500.00);
            ContaBancaria p5 = new ContaBancaria("Jessica", "123845679", "329876541", 1500.00);
            ContaBancaria p6 = new ContaBancaria("Luan", "125678934", "976543218", 4000.00);


            List<ContaBancaria> itau = new List<ContaBancaria>();
            itau.Add(p1);
            itau.Add(p2);
            itau.Add(p3);
            itau.Add(p4);
            itau.Add(p5);
            itau.Add(p6);

            foreach (ContaBancaria ind in itau)
            {
                Console.WriteLine("Nome: " + ind.Nome + ", saldo: " + ind.Conta);
            }

            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("USUARIOS QUE APRESENTAM SALDO ACIMA DE 4500 REAIS");

            var conta = itau.Where(c => c.Conta > 4500);

            foreach (ContaBancaria c in conta)
            {
                Console.WriteLine(c.Nome + ", com o saldo de " + c.Conta + " reais.");

            }

            Console.WriteLine("A soma das contas filtradas é de " + conta.Sum(c => c.Conta) + " reais.");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("A média das contas filtradas é de " + conta.Average(c => c.Conta) + " reais.");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Possue " + conta.Count(c => c.Conta < 6000) + " contas filtradas abaixo de 6000 reais.");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            var maior = (from teste in itau select teste.Conta + " reais da pessoa " + teste.Nome + ".").Max();
            /*string nomeM = "";
            double contaM = 0;
            foreach(ContaBancaria ind in itau)
            {
                if (ind.Conta > contaM)
                {
                    contaM = ind.Conta;
                    nomeM = ind.Nome;
                }
            }
            */
            Console.WriteLine("O maior valor da conta Itaú é de " + maior);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            var resultado = from ordem in itau
                            where ordem.Conta > 4000
                            orderby ordem.Nome ascending 
                            select ordem;
            Console.WriteLine("ORDENANDO A LISTA POR NOME (de baixo pra cima) ----------------------------------------------------------------------");
            foreach (ContaBancaria c in resultado)
            {
                Console.WriteLine(c.Conta + " " + c.Nome) ;

            }
            Console.WriteLine("-------------------------------------------------------------------------------------------------");







        }
    }
}
