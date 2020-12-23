using System;
using System.Collections.Generic;
using System.Text;

namespace S04EXNotaAluno
{
    class Aluno
    {

        public string Nome;
        public double N1;
        public double N2;
        public double N3;


        public void NotaFinal()
        {

            double notafinal = (N1 + N2 + N3);
            double reprovado = (60 - notafinal);

            if (notafinal >= 60)
            {
                Console.WriteLine("Nota Final = " + notafinal.ToString("F2"));
                Console.WriteLine("Aprovado");
            }

            else{
                Console.WriteLine("Nota Final = " + notafinal.ToString("F2"));
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + reprovado + " pontos");
            }

        }


    }


}



