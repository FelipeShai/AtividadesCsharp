using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso.Questoes
{
    static class Questao7
    {
        public static void Executar()
        {
            //exercicios2-estrutura-condicional;
            //questão 1
            //Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não
            Console.WriteLine("Digite um número inteiro");
            int numero = int.Parse(Console.ReadLine());
            if (numero > 0)
            {
                Console.WriteLine("O número é positivo");

            }
            else if (numero < 0)
            {
                Console.WriteLine("O número é negativo");
            }
            else
            {
                Console.WriteLine("Zero é um número neutro");
            }
        }
    }
}
