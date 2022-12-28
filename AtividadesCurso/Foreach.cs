using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso
{
    public class Foreach
    {
        public static void Executar()
        {
            string[] vetor = new string[]
            {
                "Felipe", "Túlio", "Alexandre", "João", "Leonardo"
            };

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }

            Console.WriteLine("--------------------------");
            foreach (string obj in vetor)
            {
                Console.WriteLine(obj);
            }
        } 
    }
}
