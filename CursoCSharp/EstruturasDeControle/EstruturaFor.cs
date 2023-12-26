using System;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"O valor de i é {i}");
            //}

            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int tamanhoTurma = Convert.ToInt32(entrada);

            for (int i = 1; i <= tamanhoTurma; i++)
            {
                Console.WriteLine($"Informe a nota do aluno {i}: ");
                entrada = Console.ReadLine();
                double notaAtual = Convert.ToDouble(entrada);

                somatorio += notaAtual;
            }

            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine($"Média da turma é {media}");

        }
    }
}
