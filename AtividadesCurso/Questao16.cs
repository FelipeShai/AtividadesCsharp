using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso
{
    static class Questao16
    {
        public static void Executar()
        {
            //exercicios3-estrutura-while
            //questão 2
            //Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema 
            //cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            //menos uma de duas coordenadas for NULA(nesta situação sem escrever mensagem alguma).
            Console.WriteLine("Digite o valor das coordenadas X e Y");
            String[] numeros = Console.ReadLine().Split(' ');
            int coordenadaX = int.Parse(numeros[0]);
            int coordenadaY = int.Parse(numeros[1]);

            while(coordenadaX != 0 && coordenadaY != 0)
            {
                if (coordenadaX > 0 && coordenadaY > 0)
                {
                    Console.WriteLine("Primeiro Quadrante");
                }
                else if (coordenadaX < 0 && coordenadaY > 0)
                {
                    Console.WriteLine("Segundo Quadrante");
                }
                else if (coordenadaX < 0 && coordenadaY < 0)
                {
                    Console.WriteLine("Terceiro Quadrante");
                }
                else if (coordenadaX > 0 && coordenadaY < 0)
                {
                    Console.WriteLine("Quarto Quadrante");
                }
                Console.WriteLine("------------------------------");
                Console.WriteLine("Digite novas coordenadas X e Y");
                numeros = Console.ReadLine().Split(' ');
                coordenadaX = int.Parse(numeros[0]);
                coordenadaY = int.Parse(numeros[1]);
            }

        }
    }
}
