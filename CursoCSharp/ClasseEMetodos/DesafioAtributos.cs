using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos
{
    class DesafioAtributos
    {
        int a = 10;

        public static void Executar()
        {
            DesafioAtributos desafio = new DesafioAtributos();
            desafio.a = 5;
            Console.WriteLine(desafio.a);
        }
    }
}
