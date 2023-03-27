using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso.Questoes
{
    static class Questao4
    {
        public static void Executar()
        {
            //exercicios1-estrutura-sequencial;
            //questão 4
            //Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
            //hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas
            //decimais
            Console.Write("Digite o número do funcionario: ");
            int numeroFuncionario = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de horas trabalhadas: ");
            double HorasTrabalhadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor/hora desse funcionário: $");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = HorasTrabalhadas * valorHora;
            Console.WriteLine($"O salário do funcionário {numeroFuncionario} é de ${salario.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
