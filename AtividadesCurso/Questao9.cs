using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso
{
    static class Questao9
    {
        public static void Executar()
        {
            //exercicios2-estrutura-condicional;
            //questão 3
            /*Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
            Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
            ordem crescente ou decrescente.*/
            string numeros = Console.ReadLine();
            string[] numerosArray = numeros.Split(' ');
            int numero1 = int.Parse(numerosArray[0]);
            int numero2 = int.Parse(numerosArray[1]);
            if (numero1 % numero2 == 0 || numero2 % numero1 == 0)
            {
                Console.WriteLine("São múltiplos");
            }
            else
            {
                Console.WriteLine("Não são múltiplos");
            }
        }
}
}
