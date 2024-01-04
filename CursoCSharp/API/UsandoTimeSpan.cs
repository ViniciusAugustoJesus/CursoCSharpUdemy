using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.API
{
    class UsandoTimeSpan
    {
        public static void Executar()
        {
            var intervalo = new TimeSpan(10, 20, 30, 40);
            Console.WriteLine(intervalo);

            Console.WriteLine(intervalo.TotalSeconds); 
            Console.WriteLine(intervalo.TotalMinutes);

            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(15);

            var tempo = chegada - largada;

            Console.WriteLine(tempo);

            Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(8)));
        }
    }
}
