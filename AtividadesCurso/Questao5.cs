using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace AtividadesCurso
{
    static class Questao5
    {
        public static void Executar()
        {
            //exercicios1-estrutura-sequencial;
            //questão 5
            //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            //código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.
            Console.WriteLine("Digite o código, quantidade e o valor unitário da primeira peça");
            string codigo_numero_valor1 = Console.ReadLine();
            string[] codigo_numero_valorArray1 = codigo_numero_valor1.Split(' '); 
            int codPeca1 = int.Parse(codigo_numero_valorArray1[0]);
            double numeroPecas1 = double.Parse(codigo_numero_valorArray1[1],CultureInfo.InvariantCulture);
            double valorUnitarioPeca1 = double.Parse(codigo_numero_valorArray1[2],CultureInfo.InvariantCulture);
            double valorTotalProduto1 = numeroPecas1 * valorUnitarioPeca1;

            Console.WriteLine("Digite o código, quantidade e o valor unitário da segunda peça");
            string codigo_numero_valor2 = Console.ReadLine();
            string[] codigo_numero_valorArray2 = codigo_numero_valor2.Split(' ');
            int codPeca2 = int.Parse(codigo_numero_valorArray2[0]);
            double numeroPecas2 = double.Parse(codigo_numero_valorArray2[1],CultureInfo.InvariantCulture);
            double valorUnitarioPeca2 = double.Parse(codigo_numero_valorArray2[2],CultureInfo.InvariantCulture);
            double valorTotalProduto2 = numeroPecas2 * valorUnitarioPeca2;

            double total = valorTotalProduto1 + valorTotalProduto2;
            Console.WriteLine($"Valor a ser pago é: R${total.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}