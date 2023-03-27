using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso.Questoes
{
    static class Questao12
    {
        public static void Executar()
        {
            //exercicios2-estrutura-condicional;
            //questão 6
            //Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos 
            //seguintes intervalos([0,25], (25, 50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em
            //nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”

            Console.WriteLine("Digite um número inteiro entre 0 e 100");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0 && numero <= 25)
            {
                Console.WriteLine("O número digitado está entre 0 e 25");
            }
            if (numero >= 25 && numero <= 50)
            {
                Console.WriteLine("O número digitado está entre 25 e 50");
            }
            if (numero >= 50 && numero <= 75)
            {
                Console.WriteLine("O número digitado está entre 50 e 75");
            }
            if (numero >= 75 && numero <= 100)
            {
                Console.WriteLine("O número digitado está entre 75 e 100");
            }
        }
    }
}