namespace S04ExConversor
{
    class ConversorDeMoeda
    {

        static public double ConverterMoeda(double cotacao, double qtd)
        {
            double valorF = cotacao * qtd;
            return valorF * 1.06;

        }



    }
}
