using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Fila
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Fulano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Sicrano");

            Console.WriteLine(fila.Peek()); 
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach(var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }


        }
    }
}
