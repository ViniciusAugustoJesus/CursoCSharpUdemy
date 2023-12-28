﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos
{
    class ParametrosPadrao
    {
        public static int Somar(int a = 1, int b = 1)
        {
            return a + b;
        }
        public static void Executar()
        {
            Console.WriteLine(Somar(10,50));
            Console.WriteLine(Somar(50)); 
            Console.WriteLine(Somar());  
            Console.WriteLine(Somar(b: 7));  
        }
    }
}
