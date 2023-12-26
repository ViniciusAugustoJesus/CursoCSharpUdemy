using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C")); 
            Console.WriteLine(valor.ToString("D"));  
            Console.WriteLine(valor.ToString("#.##"));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D0"));


        }
    }
}
