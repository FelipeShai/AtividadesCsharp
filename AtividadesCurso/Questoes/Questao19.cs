using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso.Questoes
{
    static class Questao19
    {
        public static void Executar()
        {
            //exercicios4-estrutura-for
            //questão 2
            /*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
            essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).*/

            int n = int.Parse(Console.ReadLine());

            int cont_in = 0;
            int cont_out = 0;

            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    cont_in = cont_in + 1;
                }
                else
                {
                    cont_out = cont_out + 1;
                }
            }

            Console.WriteLine(cont_in + " in");
            Console.WriteLine(cont_out + " out");
        }
    }
}

