using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{

    class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj)
        {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Preco);
        }
    }
    class Lista
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>()
            {
                new Produto("Camisa", 29.9),
                new Produto("8 temporada Game of Thrones", 99.9),
                new Produto("Poster", 10)

            };

            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach(var item in carrinho)
            {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            carrinho.Add(livro);
            Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
