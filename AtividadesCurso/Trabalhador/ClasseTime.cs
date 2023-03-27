using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso.Trabalhador
{
    internal class ClasseTime
    {
        private string Desenvolvedor { get; set; }
        private string DesenvolvedorUm { get; set; }

        public ClasseTime(string desenvolvedor, string desenvolvedorUm)
        {
            Desenvolvedor = desenvolvedor;
            DesenvolvedorUm = desenvolvedorUm;
        }
    }
}
