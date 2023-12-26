using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis E Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"NotacaoPonto - Fundamentos", Inferencia.Executar}, 
                {"LendoDados - Fundamentos", LendoDados.Executar}, 
                {"FormatandoNumero - Fundamentos", FormatandoNumero.Executar}, 
                {"Operadores Arimiteticos - Fundamentos", OperadoresAritimeticos.Executar}, 
            });

            central.SelecionarEExecutar();
        }
    }
}