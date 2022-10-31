using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso
{
    static class Questao1
    {
        public static void Executar()

        {
            //exercicios1-estrutura-sequencial;
            //questão 1
            //Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
            //mensagem explicativa, conforme exemplos
            Console.WriteLine("Digite o primeiro número inteiro da soma");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número inteiro da soma");
            int numero2 = int.Parse(Console.ReadLine());
            int resultado = soma(numero1, numero2);
            Console.WriteLine($"O resultado é: {resultado}");
        }
        //funçao
        static int soma(int a, int b) 
        { 
            return a + b; 
        }
    }
}
