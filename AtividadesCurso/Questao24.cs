using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso
{
    public static class Questao24
    {
        public static void Executar()
        {
            //exercicios4-estrutura-for
            //questão 7
            /*Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas, 
            começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme 
            exemplo.*/
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");

            }
        }

    }
}


