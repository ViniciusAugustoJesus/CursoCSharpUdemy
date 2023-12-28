namespace CursoCSharp.ClasseEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;
        string nome;
        public string Nome
        {
            get
            {
                return $"Opcional: {nome}";
            }
            set
            {
                nome = value;
            }
        }

        public double Preco { get; set; }

        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco); //Lambda

            //get
            //{
            //    return Preco - (desconto * Preco);
            //}
        }
    }

    class Props
    {


        public static void Executar()
        {

        }
    }
}
