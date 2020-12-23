using System;
using System.Collections.Generic;
using System.Text;

namespace EXS05ContaBancariaComEncapsulamentoeProperties
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string TitularConta { get; private set; }
        public double Saldo { get; private set; }


        public ContaBancaria(string titular_conta, int numero_conta)
        {
            TitularConta = titular_conta;
            NumeroConta = numero_conta;
        }

        public ContaBancaria(string titular_conta, int numero_conta, double deposito) : this(titular_conta,numero_conta)
        {
            DepositarDinheiro(deposito);
        }

        public void DepositarDinheiro(double valor)
        {
            Saldo += valor;
            Console.WriteLine("Dados da conta atualizados:");
        }

        public void SacarDinheiro(double valor)
        {
            Saldo -= valor + 5; //Taxa de 5 reais.
            Console.WriteLine("Dados da conta atualizados:");
        }


        public static double TemDeposito(char temDeposito)
        {
            if (temDeposito == 's' || temDeposito == 'S')
            {
                Console.Write("De quanto será o valor do depósito inicial?: R$");
                double valorDeposito = double.Parse(Console.ReadLine());
                Console.WriteLine("Dados da conta:");

                return valorDeposito;
            }
            else return 0;
            
        }

        public override string ToString()
        {
            return
                "Conta: " + NumeroConta +
                ", Titular: " + TitularConta +
                " , Saldo R$: " + Saldo.ToString("F2");
                ;
        }

    }
}
