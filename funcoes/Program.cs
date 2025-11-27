/*  Função, o que é?
Em lógica de programação, uma função é um bloco de código criado para executar uma tarefa específica e que pode retornar um valor após ser executado.
✔️ Como funciona uma função
Você define a função uma vez.
Sempre que precisar daquela tarefa, você chama a função pelo nome.
A função pode receber dados (parâmetros) e devolver um resultado (retorno).
 */



using System;
using System.Runtime.Serialization;

class program
{
    static void Main()
    {
        //Chama uma função simples que imprime uma mensagem
        ImprimirMensagem();

        //Exemplo de funções para cálculo de áreas (modularização)
        Console.WriteLine("\n --- Áreas ---");
        Console.WriteLine("Quadrado:" + CalcularAreaQuadrado(4));
        Console.WriteLine("Círculo: " + CalcularAreaCirculo(3));

        // Exemplo de programa divivdido em funções: entrad, processamento e saída
        Console.WriteLine("\n--- Média de Notas ---");
        double[] notas = EntrarNotas(3);        // Entrada de dados
        double media = CalcularMedia(notas);    // Processamento
        Console.WriteLine("Média: " + media);   // Saída
    }

    // Função simples que exibe uma mensagem no console
    static void ImprimirMensagem() => Console.WriteLine("Olá, mundo!");

    //Funcão que calcula a área de um círculo
    static double CalcularAreaQuadrado(double lado) => lado * lado;

    //Funcão que calcula a área de um quadrado
    static double CalcularAreaCirculo(double raio) => Math.PI * raio * raio;

        //Função que lê notas digitadas pelo usuário e armazena um vetor
        static double[] EntrarNotas(int qtd)
        {
            double[] notas = new double[qtd];
            for (int i = 0; i < qtd; i++)
            {
                Console.Write("Nota" + (i + 1) + ": ");
                notas[i] = double.Parse(Console.ReadLine());
            }
            return notas;
        }

        //Função que calcula a média de um vetor de notas
        static double CalcularMedia(double[] notas)
        {
            double soma = 0;
            foreach (double n in notas) soma += n;
            return soma / notas.Length;
        }
}

