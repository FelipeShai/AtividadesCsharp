using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso.ExercicioListas
{
    public class FuncionarioLogica
    {
        public void Executar()
        {
            int numeroFuncionarios;
            Console.WriteLine("Digite o numero de usuários que deseja incluir no sistema.");
            numeroFuncionarios = int.Parse(Console.ReadLine());
            List<Funcionario> listaFuncionario = new List<Funcionario>();

            for (int i = 1; i <= numeroFuncionarios; i++)
            {
                string nomeFuncionario;
                double salarioFuncionario;
                string resposta;
                Console.WriteLine($"Digite o nome do Funcionario {i}");
                nomeFuncionario = Console.ReadLine();
                Console.WriteLine($"Digite o salário atual do Funcionario {i}");
                salarioFuncionario = int.Parse(Console.ReadLine());
                listaFuncionario.Add(new Funcionario(i, nomeFuncionario, salarioFuncionario));
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"Deseja aumentar o valor de salário do Funcionário {i}?");
                resposta = Console.ReadLine();
                if(resposta == "Sim")
                {
                    int porcentagemAumento;
                    Console.Write("Digite a porcentagem: ");
                    porcentagemAumento = int.Parse(Console.ReadLine());
                    listaFuncionario[i - 1].EfetuarAumento(i, porcentagemAumento);
                    Console.WriteLine("---------------------------------------");
                }
                else
                {
                    Console.WriteLine("Ok!");
                    Console.WriteLine("---------------------------------------");
                }
            }

            foreach (Funcionario lista in listaFuncionario)
            {
                Console.WriteLine($"Dados Funcionario {lista}");
                Console.WriteLine(listaFuncionario);
                Console.WriteLine("---------------------------------------");
            }
        }
    }
}
