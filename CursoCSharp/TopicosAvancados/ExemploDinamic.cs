using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class ExemploDinamic
    {
        public static void Executar()
        {
            dynamic meuObjeto = "teste";

            meuObjeto = 10;
            meuObjeto++;
            Console.WriteLine(meuObjeto);

            
        }
    }
}
