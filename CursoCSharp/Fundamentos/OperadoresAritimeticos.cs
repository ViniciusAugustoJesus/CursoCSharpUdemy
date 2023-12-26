using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritimeticos
    {
        public static void Executar()
        {
            double preco = 1000;
            int imposto = 355;
            double desconto = 0.1;

            double total = preco + imposto;
            double totalComDesconto = total - total * desconto;
            Console.WriteLine($"O preço final é {totalComDesconto}");

            double peso = 70;
            double altura = 1.75;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {imc}");

            
        }
    }
}
