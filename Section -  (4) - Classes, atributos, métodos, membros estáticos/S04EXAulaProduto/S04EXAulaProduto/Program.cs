using System;

namespace S04EXAulaProduto
{
    class Program
    {
        static void Main(string[] args)
        {

            bool cont = false;

            Produto p1;

            p1 = new Produto();

            Console.Write("Digite o nome do produto:");

            p1.Nome = Console.ReadLine();


            Console.Write("Digite o preço do produto R$:");

            p1.Preco = int.Parse(Console.ReadLine());

            Console.Write("Digite a qtd em estoque do produto:" );

            p1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine(p1);



            while (cont == false)
            {
                Console.WriteLine("______________________________________________________________");
                Console.WriteLine("Menu");
                Console.WriteLine("Digite 1 para adicionar X quantidades do produto em estoque");
                Console.WriteLine("Digite 2 para remover X quantidades do produto em estoque");
                Console.WriteLine("Digite 3 para mostrar a quantidade do produto em estoque");
                Console.WriteLine("Digite 4 para mostrar o valor total do estoque");
                Console.WriteLine("Digite 5 para sair do sistema");
                Console.WriteLine("______________________________________________________________");

                int entrada = int.Parse(Console.ReadLine());

                if (entrada == 1)
                {

                    Console.Write("Quantas unidades do produto você deseja adicionar? :");
                    int addProd = int.Parse(Console.ReadLine());
                    p1.AdicionarProdutos(addProd);
                    Console.WriteLine(p1);

                }


                if (entrada == 2)
                {
                    Console.Write("Quantas unidades do produto você deseja remover? :");
                    int removeProd = int.Parse(Console.ReadLine());
                    p1.RemoverProdutos(removeProd);
                    Console.WriteLine(p1);
                }


                if (entrada == 3)
                {

                    Console.WriteLine("Quantidade atual no estoque: " + p1.Quantidade);

                }


                if (entrada == 4)
                {

                    Console.WriteLine("Valor total de " + p1.Nome + " em estoque R$:" + p1.ValorTotalEmEstoque());

                }


                if (entrada == 5)
                {
                    cont = true;
                    Console.WriteLine("sistema encerrado");
                }


            }

        }
    }
}
