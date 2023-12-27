using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos
{

    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro (string modelo, string fabricante, int ano)
        {
            this.Modelo = modelo;
            this.Fabricante = fabricante;
            this.Ano = ano;
        }
    }

    class Construtores
    {
        public static void Executar()
        {
            var carro1 = new Carro("325i", "BMW", 2022);
            Console.WriteLine(carro1.Modelo, carro1.Fabricante, carro1.Ano);

        }
    }
}
