using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso
{
    static class Questao8
    {
        public static void Executar()
        {
            //exercicios2-estrutura-condicional;
            //questão 2
            //Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

            Console.WriteLine("Digite um número para saber se é ímpar ou par");
            int numero = int.Parse(Console.ReadLine());
            if(numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");  
            }
        }
    }
}
