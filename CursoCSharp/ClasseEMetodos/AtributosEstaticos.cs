namespace CursoCSharp.ClasseEMetodos
{
    class AtributosEstaticos
    {

        public class Produto
        {
            public string Nome;
            public double Preco;
            public static double Desconto = 0.1;

            public Produto(string nome, double preco, double desconto)
            {
                Nome = nome;
                Preco = preco;
                Desconto = desconto;
            }

            public Produto()
            {

            }

            public double calcularDesconto()
            {
                return Preco - Preco * Desconto;
            }
        }

        public static void Executar()
        {
            Produto produto1 = new Produto("Caneta", 3.2, 0.1);

            Produto produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3
            };

            Produto.Desconto = 0.5;

            System.Console.WriteLine($"Preço com desconto: {produto1.calcularDesconto()}"); 
            System.Console.WriteLine($"Preço com desconto: {produto2.calcularDesconto()}");

            Produto.Desconto = 0.02;

            System.Console.WriteLine($"Preço com desconto: {produto1.calcularDesconto()}");
            System.Console.WriteLine($"Preço com desconto: {produto2.calcularDesconto()}");

        }
    }
}
