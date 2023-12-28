namespace CursoCSharp.ClasseEMetodos
{

    interface Ponto
    {
        void moverNaDiagonal(int delta);
    }

    struct Coordenada: Ponto
    {
        public int X; 
        public int Y; 

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void moverNaDiagonal(int delta)
        {
            X += delta; 
            Y += delta; 
        }
    }

    class ExemploStruct
    {
        public static void Executar()
        {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2; 
            coordenadaInicial.Y = 2;

            System.Console.WriteLine("Coordenada Inicial:");
            System.Console.WriteLine($"X = {coordenadaInicial.X}"); 
            System.Console.WriteLine($"Y = {coordenadaInicial.Y}");

            var coordenadaFinal = new Coordenada(x:9, y:1);
            coordenadaFinal.moverNaDiagonal(10);

            System.Console.WriteLine("Coordenada Final:");
            System.Console.WriteLine($"X = {coordenadaFinal.X}"); 
            System.Console.WriteLine($"Y = {coordenadaFinal.Y}"); 

        }
    }
}
