using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos
{

    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento()
        {
            return $"{Nascimento.Day}/{Nascimento.Month}/{Nascimento.Year}";
        }
    }
    class AtributosReadonly
    {
        public static void Executar()
        {
            Cliente novoCliente = new Cliente("Ana", new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }
}
