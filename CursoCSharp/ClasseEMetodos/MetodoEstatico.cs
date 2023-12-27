using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos
{   

    class CalculadoraEstatica
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }

    class MetodoEstatico
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2,2);
            Console.WriteLine(resultado);


        }
    }
}
