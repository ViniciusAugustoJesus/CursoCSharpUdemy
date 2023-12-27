using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa fulano = new Pessoa();
            fulano.Nome = "Jorge";
            fulano.Idade = 20;

            //Console.WriteLine($"{fulano.Nome} tem {fulano.Idade} anos");

            fulano.ApresentarNoConsole();
        }
    }
}
