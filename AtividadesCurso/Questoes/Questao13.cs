using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso.Questoes
{
    static class Questao13
    {
        public static void Executar()
        {
            //exercicios2-estrutura-condicional;
            //questão 7
            //Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas 
            //de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
            //ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0).
            //Se o ponto estiver na origem, escreva a mensagem “Origem”.
            //Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
            //situação
            Console.WriteLine("Digite o valor de X e Y");
            string[] valoresArray = Console.ReadLine().Split(' ');
            double x = double.Parse(valoresArray[0]);
            double y = double.Parse(valoresArray[1]);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Primeiro Quadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Segundo Quadrante");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Terceiro Quadrante");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Quarto Quadrante");
            }
            else
            {
                Console.WriteLine("Neutro");
            }
        }
    }
}