﻿using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClasseEMetodos;
using CursoCSharp.Colecoes; 
using CursoCSharp.OO; 

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

                {"For - Estruturas de Controle", EstruturaFor.Executar}, 
                {"Foreach - Estruturas de Controle", EstruturaForeach.Executar}, 
                {"Break - Estruturas de Controle", UsandoBreak.Executar},  
                {"Continue - Estruturas de Controle", UsandoContinue.Executar},  
                
                {"Membros - Classes e Metodos", Membros.Executar},  
                {"Construtores - Classes e Metodos", Construtores.Executar},  
                {"Metodos com retorno - Classes e Metodos", MetodosComRetorno.Executar},  
                {"Metodos estaticos - Classes e Metodos", MetodoEstatico.Executar},  
                {"Atributos estaticos - Classes e Metodos", AtributosEstaticos.Executar},  
                {"Desafio atributos - Classes e Metodos", DesafioAtributos.Executar},  
                {"Params - Classes e Metodos", Params.Executar},  
                {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar},  
                {"Props - Classes e Metodos", Props.Executar},  
                {"Atributos Readonly - Classes e Metodos", AtributosReadonly.Executar},  
                {"ExemploEnum - Classes e Metodos", ExemploEnum.Executar},  
                {"Struct - Classes e Metodos", ExemploStruct.Executar},   
                {"Struct vs Classe - Classes e Metodos", StructVsClasse.Executar},   
                {"ValorVsReferencia- Classes e Metodos", ValorVsReferencia.Executar},   
                {"ParametrosPorReferencia- Classes e Metodos", ParametrosPorReferencia.Executar},   
                {"ParametrosPadrao- Classes e Metodos", ParametrosPadrao.Executar},   
                
                {"Array - Coleções", ExemploArray.Executar},   
                {"List - Coleções", Lista.Executar},   
                {"ArrayList - Coleções", ColecaoArrayList.Executar},   
                {"Set - Coleções", ColecaoSet.Executar},   
                {"Fila - Coleções", Fila.Executar},   
                {"Igualdade - Coleções", Igualdade.Executar}, 
                {"Stack - Coleções", ColecaoStack.Executar}, 
                {"Dicionario - Coleções", ColecaoDicionario.Executar}, 

                {"Herança - OO", Heranca.Executar}, 
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", UsandoEncapsulamento.Executar}, 
                {"Polimorfismo - OO", Polimorfismo.Executar}, 
            });

            central.SelecionarEExecutar();
        }
    }
}