using System;
using System.Globalization;

namespace AtividadesCurso.Questoes
{
    static class Questao2
    {
        public static void Executar()
        {
            //exercicios1-estrutura-sequencial;
            //questão 2
            //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
            //casas decimais conforme exemplos.
            Console.WriteLine("Digite o raio da circunferência que deseja saber a área");
            double raio = double.Parse(Console.ReadLine());
            double resultadoArea = area(raio);
            Console.WriteLine($"A área de uma circunferência de raio {raio} é igual a: {resultadoArea.ToString("F2")}");
        }

        //função
        static double area(double raio)
        {
            return 3.14159 * Math.Pow(raio, 2);
        }
    }
}