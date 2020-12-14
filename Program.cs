using System;

namespace POO_static
{
    class Program
    {
        static void Main(string[] args)
        {   
            // chamanddo o Método que estao em static
            // método static só conversam com métodos static
            // métodos comuns conversam com métodos comuns 

            Console.WriteLine($" A conversão do Dolar em Real fica : {Conversor.DolarParaReal(52)}");

            Console.WriteLine($" A conversão do Real em Dolar fica : {Conversor.RealParaDolar(52)}");

            Console.WriteLine($" A conversão do Euro em Real fica : {Conversor.EuroParaReal(50)}");

            Console.WriteLine($" A conversão do Real em Euro fica : {Conversor.RealParaEuro(50)}");

        }
    }
}
