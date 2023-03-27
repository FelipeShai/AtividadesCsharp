using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso.Questoes
{
    static class Questao15
    {
        public static void Executar()
        {
            //exercicios3-estrutura-while
            //questão 1
            /*Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha 
            incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser 
            impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002*/
            Console.WriteLine("Digite uma senha válida:");
            int senhaValida = int.Parse(Console.ReadLine());
            while (senhaValida != 123456)
            {
                Console.WriteLine("Senha errada, digite novamente");
                senhaValida = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Senha correta");

        }
    }
}
