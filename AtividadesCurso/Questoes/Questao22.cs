using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso.Questoes
{
    public static class Questao22
    {
        public static void Executar()
        {
            //exercicios4-estrutura-for
            //questão 5
            /*Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
            Lembrando que, por definição, fatorial de 0 é 1.*/

            double i, numero, fatorial;
            Console.WriteLine("Informe o número");
            numero = double.Parse(Console.ReadLine());

            fatorial = numero;
            for (i = numero - 1; i >= 1; i--)
            {
                Console.WriteLine($"{fatorial} * {i}");

                fatorial = fatorial * i;

                Console.WriteLine($"i={i}");
                Console.WriteLine($"fatorial={fatorial}");
                Console.WriteLine("  ");
            }
            Console.WriteLine($"\nFatorial de {numero} é {fatorial} ");
            Console.ReadLine();
        }
    }
}
