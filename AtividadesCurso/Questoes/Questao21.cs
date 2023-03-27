using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso.Questoes
{
    static class Questao21
    {
        public static void Executar()
        {
            //exercicios4-estrutura-for
            //questão 4
            /*Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo 
            segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel"*/
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string[] numeroArray = Console.ReadLine().Split(' ');
                double n1 = double.Parse(numeroArray[0]);
                double n2 = double.Parse(numeroArray[1]);
                double resultado;
                resultado = n1 / n2;
                Console.WriteLine(resultado.ToString("F2"));
            }
        }
    }
}
