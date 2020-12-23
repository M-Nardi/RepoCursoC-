using System;
using System.Collections.Generic;
using System.Text;

namespace S04ExSalarioFunc
{
    class Funcionario
    {

        public string Nome;
        public double Salario;
        public double Imposto;


        public override string ToString()
        {
            return "Dados atualizados:" + Nome + ", R$ " + Salario.ToString("F2");
        }

        public double SalarioLiquido()
        {
            double salarioLiq = Salario - Imposto;
            return salarioLiq;

        }


        public void AumentarSalario(double porc)
        {
            double porcentagem = 1 + (porc / 100);
            Salario = SalarioLiquido() * porcentagem;

        }

        


    }


}
