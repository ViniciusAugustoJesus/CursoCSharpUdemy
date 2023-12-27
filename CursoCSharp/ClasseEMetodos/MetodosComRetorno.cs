using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos
{
    class MetodosComRetorno
    {

        class CalculadoraComum
        {
            public int Somar(int a, int b)
            {
                return a + b;
            }

            public int Subtrar(int a, int b)
            {
                return a - b;
            }

            public int Dividir(int a, int b)
            {
                return a / b;
            }

        }

        class CalculadoraCadeia
        {
            int memoria;

            public CalculadoraCadeia Somar(int a)
            {
                memoria += a;
                return this;
            }

            public CalculadoraCadeia Multiplicar(int a)
            {
                memoria *= a;
                return this;
            }

            public CalculadoraCadeia Limpar()
            {
                memoria = 0;
                return this;
            }

            public CalculadoraCadeia Imprimir()
            {
                Console.WriteLine(memoria); 
                return this;
            }

            public int Resultado()
            {
                return memoria;
            }
        }

        public static void Executar()
        {
            CalculadoraComum calculadoraComum = new CalculadoraComum();

            int resultado = calculadoraComum.Somar(2, 5);
            Console.WriteLine(resultado);

            CalculadoraCadeia calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(2).Imprimir().Limpar().Imprimir();
        }
    }
}
