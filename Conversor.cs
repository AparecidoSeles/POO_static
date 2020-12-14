namespace POO_static
{
    public static class Conversor
    {
        //Atributos
        private static float cotacaoDolar = 5.24f;
        public static float cotacaoEuro = 6.16f;

        public static float RealParaDolar( float valorRS ){

            return valorRS / cotacaoDolar;
        }

        public static float DolarParaReal( float valorUS){

            return valorUS * cotacaoDolar;
        }

        public static float RealParaEuro( float valorRS){

            return valorRS / cotacaoEuro;
        }

        public static float EuroParaReal( float valorEUR){

            return valorEUR * cotacaoEuro;
        }
    }
}