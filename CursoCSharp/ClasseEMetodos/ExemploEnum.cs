using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos
{

    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia}

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    class ExemploEnum
    {
        public static void Executar()
        {
            int id = Convert.ToInt32(Genero.Animacao);
            Console.WriteLine(id);

            Filme filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknado 17";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine($"{filmeParaFamilia.Titulo} é {filmeParaFamilia.GeneroDoFilme}");
        }
    }
}
