namespace CursoCSharp.OO
{

    class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        public Carro() { }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;
             
            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            } else
            {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }

      

    }

    public class Uno : Carro
    {
        public Uno() : base(200)
        {

        }
    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(350)
        {

        }

        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }

        public new int Frear()
        {
            return AlterarVelocidade(-15);
            }
    }


    class Heranca
    {
        public static void Executar()
        {
            System.Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            System.Console.WriteLine(carro1.Acelerar()); 
            System.Console.WriteLine(carro1.Acelerar()); 
            System.Console.WriteLine(carro1.Frear()); 
            System.Console.WriteLine(carro1.Frear()); 
            
        }
    }
}
