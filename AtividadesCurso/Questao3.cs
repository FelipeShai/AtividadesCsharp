using System;

namespace AtividadesCurso
{
    static class Questao3
    {
        public static void Executar()
        {
            //exercicios1-estrutura-sequencial;
            //questão 3
            //Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
            //de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
            Console.WriteLine("Digite 4 números inteiros");
            string valores = Console.ReadLine();
            string[] valoresArray = valores.Split(' ');
            int numeroA = int.Parse(valoresArray[0]);
            int numeroB = int.Parse(valoresArray[1]);
            int numeroC = int.Parse(valoresArray[2]);
            int numeroD = int.Parse(valoresArray[3]);
            int diferenca = (numeroA * numeroB - numeroC * numeroD);
            Console.WriteLine($"A diferença de {numeroA} por {numeroB} vezes {numeroC} por {numeroD} é: {diferenca}");
        }
    }
}
