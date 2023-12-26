using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade?");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o seu salario?");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Seu nome é {nome}, voce tem {idade} anos e ganha R${salario}");
        }
    }
}
