using System;
using System.Collections.Generic;
using System.Text;

namespace S04EXAulaProduto
{
    class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEmEstoque()
        {
            double valorTotal = Preco * Quantidade;
            return valorTotal;
        }

        public void AdicionarProdutos(int i)
        {
            Quantidade += i;
        }

        public void RemoverProdutos(int x)
        {
            Quantidade -= x;
        }

        public override string ToString()
        {
            return "Dados atualizados: " + Nome + ", R$" + Preco.ToString("F2") + " , " + Quantidade + " unidades, Total: R$" + ValorTotalEmEstoque();

        }

    }
}
