using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos
{
    class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero += 1000;
        }

        public static void AlterarOut(out int numero)
        {
            numero = 0;
            numero += 15;
        }

        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            //out int b;
            AlterarOut(out int b);
            Console.WriteLine(b);

        }
    }
}
