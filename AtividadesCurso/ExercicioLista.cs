using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso
{
    public class ExercicioLista
    {

        public static void Executar()
        {
            Console.Write("Digite o número de funcionários que serão registrados: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            List<Funcionarios> listaFuncionarios = new List<Funcionarios>();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Informações Usuário #{i}");
                Console.Write("Digite o número ID do Funcionário: ");
                int tratamentoId = int.Parse(Console.ReadLine());

                while (VerificarIdExistente(tratamentoId, listaFuncionarios))
                {
                    Console.Write("Digite o número ID válido para registrar os dados do Funcionário: ");
                    tratamentoId = int.Parse(Console.ReadLine());
                }

                Console.Write("Digite o nome do Funcionário: ");
                string tratamentoNome = Console.ReadLine();
                Console.Write("Digite o nome do Salário ");
                double tratamentoSalario = double.Parse(Console.ReadLine());
                listaFuncionarios.Add(new Funcionarios(tratamentoId, tratamentoNome, tratamentoSalario));
                Console.WriteLine("------------------------------");
            }

            Console.Write("Digite o ID do Funcionário o qual irá receber um aumento: ");
            int idAumentoSalarial = int.Parse(Console.ReadLine());

            var funcionario = listaFuncionarios.Find(x => x.Id == idAumentoSalarial);
            if (funcionario != null)
            {
                Console.Write("Digite o valor do aumento em %: ");
                double valorAumentoSalarialPorcentagem = double.Parse(Console.ReadLine());
                funcionario.AumentoSalario(valorAumentoSalarialPorcentagem);
                Console.WriteLine("Dados atualizados: ");
                Console.WriteLine(funcionario);
            }
            else { Console.WriteLine("não encontrado"); }

            Console.WriteLine("Lista de todos os funcionarios:");
            foreach (Funcionarios Funcionario in listaFuncionarios)
            {
                Console.WriteLine(Funcionario);
            Console.WriteLine("--------------------");
            }
        }

        public static bool VerificarIdExistente(int id, List<Funcionarios> funcionarios)
        {
            var result = funcionarios.Find(x => x.Id == id);
            if (result != null) return true;
            return false;
        }

    }

    public class Funcionarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionarios(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }


        public void AumentoSalario(double porcentagem)
        {
            Salario += Salario * (porcentagem / 100);
        }

        public override string? ToString()
        {
            return "------------\n" +
                    "Id: " + Id + "\n" +
                    "Nome: " + Nome + "\n" +
                    "Salario: " + Salario;
        }
    }
}
