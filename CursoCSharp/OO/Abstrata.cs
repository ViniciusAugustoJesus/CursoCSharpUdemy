namespace CursoCSharp.OO
{
    public abstract class Celular
    {
        public abstract string Assistente();

        public string Tocar()
        {
            return "Trim Trim";
        }
    }

    public class Iphone : Celular 
    {
        public override string Assistente()
        {
            return "Siri";
        }
    }

    class Abstrata
    {
        public static void Executar()
        {
            Celular celular = new Iphone();
            celular.Assistente();
        }
    }
}
