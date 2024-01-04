using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.API
{
    class UsandoDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(2003, 9, 7);
            Console.WriteLine(dateTime.Day); 
            Console.WriteLine(dateTime.Month);  
            Console.WriteLine(dateTime.Year);

            //Sem Horas
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            //Com hora
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);
        }
    }
}
