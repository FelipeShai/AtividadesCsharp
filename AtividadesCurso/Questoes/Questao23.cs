using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso.Questoes
{
    public static class Questao23
    {
        public static void Executar()
        {
            //exercicios4-estrutura-for
            //questão 6
            /*Ler um número inteiro N e calcular todos os seus divisores*/
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
