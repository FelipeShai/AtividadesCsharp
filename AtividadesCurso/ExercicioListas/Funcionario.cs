using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso.ExercicioListas
{
    public class Funcionario
    {
        private int IdFuncionario { get; set; }
        private string NomeFuncionario { get; set; }
        private double SalarioFuncionario { get; set; }

        public Funcionario(int idFuncionario, string nomeFuncionario, double salarioFuncionario)
        {
            IdFuncionario = idFuncionario;
            NomeFuncionario = nomeFuncionario;
            SalarioFuncionario = salarioFuncionario;
        }

        public void EfetuarAumento(int idFuncionario, double porcentagemAumento)
        {
            if (idFuncionario == IdFuncionario)
            {
                double valorAumento;
                valorAumento = SalarioFuncionario * (porcentagemAumento / 100);
                SalarioFuncionario = SalarioFuncionario + valorAumento;
            }
            else
            {
                Console.WriteLine("Falha na operação, Usuário Inexistente"); ;
                return;
            }
        }

        public override string ToString()
        {
            return IdFuncionario + ", " + 
                NomeFuncionario + ", " + 
                SalarioFuncionario.ToString("F2", CultureInfo.InvariantCulture) + ".";
        }
    }
}
