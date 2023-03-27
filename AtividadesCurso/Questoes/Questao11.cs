using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso.Questoes
{
    static class Questao11
    {
        public static void Executar()
        {
            //exercicios2-estrutura-condicional;
            //questão 5
            //Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
            //seguir, calcule e mostre o valor da conta a pagar
            Console.WriteLine("Digite o código do item desejado");
            int codigoItem = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade deste item");
            int quantidadeItem = int.Parse(Console.ReadLine());
            double totalItem;
            if (codigoItem == 1)
            {
                totalItem = 4.00 * quantidadeItem;
                Console.WriteLine($"O valor total da sua compra do item Cachorro quente é de {totalItem.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            if (codigoItem == 2)
            {
                totalItem = 4.50 * quantidadeItem;
                Console.WriteLine($"O valor total da sua compra do item X-Salada é de {totalItem.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            if (codigoItem == 3)
            {
                totalItem = 5.00 * quantidadeItem;
                Console.WriteLine($"O valor total da sua compra do item X-Bacon é de {totalItem.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            if (codigoItem == 4)
            {
                totalItem = 2.00 * quantidadeItem;
                Console.WriteLine($"O valor total da sua compra do item Torrada Simples é de {totalItem.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            if (codigoItem == 5)
            {
                totalItem = 1.50 * quantidadeItem;
                Console.WriteLine($"O valor total da sua compra do item Refrigerante é de {totalItem.ToString("F2", CultureInfo.InvariantCulture)}");
            }



        }
    }
}