using System;
using System.Collections.Generic;
using System.Text;

namespace S05VetorPensionato
{
    class Pensionato
    {
        public int NumeroQuarto { get; set; }
        public string NomeEstudante { get; set; }
        public string EmailEstudante { get; set; }


        public override string ToString()
        {
            return
                NumeroQuarto + ": " +
                NomeEstudante + ", " +
                EmailEstudante;

        }



    }




}
