using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;



namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar}, // CTRL + D na linha selecionada, duplica.
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisConstantes.Executar}, 
                {"Inferência - Fundamentos", Inferencia.Executar}, 
                {"Interpolação - Fundamentos", Interpolacao.Executar}, 
                {"Notação ponto - Fundamentos", NotacaoPonto.Executar}, 
                {"Lendo dados - Fundamentos", LendoDados.Executar}, 
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar}, 
                {"Conversões - Fundamentos", Conversoes.Executar}, 
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar}, 
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar}, 
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar}, 
                {"Operadores de atribuição - Fundamentos", OperadoresAtribuicao.Executar}, 
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar}, 
                {"Operadores Ternários - Fundamentos", OperadorTernario.Executar},
                
                 //Estrutura de controle
                {"Estrutura IF - Estrutura de Controle", EstruturaIf.Executar},
                {"Estrutura IF/Else - Estrutura de Controle", EstruturaIfElse.Executar},
                {"Estrutura IF/Else/If - Estrutura de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estrutura de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estrutura de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estrutura de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estrutura de Controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estrutura de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estrutura de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estrutura de Controle", UsandoContinue.Executar},

                //Classes e Métodos
                {"Membros - Classes e Metodos", Membros.Executar},
                {"Construtores - Classes e Metodos", Construtores.Executar},
                {"Metodos com retorno - Classes e Metodos", MetodosComRetorno.Executar},
                {"Metodos Estáticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Metodos", DesafioAtributo.Executar},
                {"Params - Classes e Metodos", Params.Executar},
                {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}