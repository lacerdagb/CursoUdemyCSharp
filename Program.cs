using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes; // importante botar o nome das pastas
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;



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
                {"Get e Set - Classes e Metodos", GetSet.Executar},
                {"Props - Classes e Metodos", Props.Executar},
                {"Readonly - Classes e Metodos", Readonly.Executar},
                {"Struct - Classes e Metodos", ExemploStruct.Executar},
                {"Struct vs Classe - Classes e Metodos", StructVsClasse.Executar},
                {"Valor vs Referência - Classes e Metodos", ValorVsReferencia.Executar},
                {"Parametros por Referencia - Classes e Metodos", ParametrosPorReferencia.Executar},
                {"Parametros com valor padrão - Classes e Metodos", ParametroPadrão.Executar},

                //Colecoes
                {"Array - Colecoes", Colecoes.Array.Executar}, // boto o Colecoes.Array pois o Array é palavra reservada.         
                {"List - Colecoes", ColecoesList.Executar},
                {"Array List - Colecoes", ColecoesArrayList.Executar},
                {"Set - Colecoes", ColecoesSet.Executar},
                {"Queue - Colecoes", ColecoesQueue.Executar},
                {"Igualdade - Colecoes", Igualdade.Executar},
                {"Coleções Stack - Colecoes", ColecoesStack.Executar},
                {"Coleções Dicionário - Colecoes", ColecoesDictionary.Executar},

                //Orientação a Objetos
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},

                // Métodos & Funções
                {"Exemplo Lambda - Metodos & funções", ExemploLambda.Executar},
                {" Lambdas com Delegates - Metodos & funções", LamdasDelegate.Executar},
                {" Usando Delegates - Metodos & funções", UsandoDelegates.Executar},
                {" Delegates como funções anonimas - Metodos & funções", DelegateFuncAnonima.Executar},
                {" Delegates como parametros - Metodos & funções", DelegatesComoParametros.Executar},
                {" Metodos de Extensão - Metodos & funções", MetodosDeExtensao.Executar},

                //Exceções
                {"Primeira exceção - Exceções", PrimeiraExcecao.Executar},



            });

            central.SelecionarEExecutar();
        }
    }
}