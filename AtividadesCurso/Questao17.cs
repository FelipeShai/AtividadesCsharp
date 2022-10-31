using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso
{
    static class Questao17
    {
        public static void Executar()
        {
            //exercicios3-estrutura-while
            //questão 3
            /*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            4.Fim). Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até
            que seja válido). O programa será encerrado quando o código informado for o número 4.Deve ser escrito a
            mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            exemplo*/

            Console.WriteLine("Digite o numero correspondente ao combustível abastecido");
            Console.WriteLine("-------------------");

            Console.WriteLine("1.Álcool\n2.Gasolina\n3.Diesel\n4.Fim");
            int numeroCombustivel;
            Console.WriteLine("-------------------");


            do
            {
                numeroCombustivel = int.Parse(Console.ReadLine());
                if (numeroCombustivel == 1)
                {
                    Console.WriteLine("Combustível: Álcool.");
                    numeroCombustivel = 4;
                }
                else if (numeroCombustivel == 2)
                {
                    Console.WriteLine("Combustível: Gasolina.");
                    numeroCombustivel = 4;
                }
                else if (numeroCombustivel == 3)
                {
                    Console.WriteLine("Combustível: Diesel.");
                    numeroCombustivel = 4;
                }
                else if (numeroCombustivel == 4)
                {
                    Console.WriteLine("Encerrado");
                    numeroCombustivel = 4;
                }


            } while (numeroCombustivel != 4);




        }
    }
}
