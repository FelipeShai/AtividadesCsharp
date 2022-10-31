using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso
{
    static class Questao10
    {
        public static void Executar()
        {
            //exercicios2-estrutura-condicional;
            //questão 4
            //Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
            //começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
            Console.WriteLine("Digite a hora inicial e a hora final");
            string[] horasArray1 = Console.ReadLine().Split(' ');
            int horasInicial = int.Parse(horasArray1[0]);
            int horasFinal = int.Parse(horasArray1[1]);
            int duracao;
            if (horasInicial < horasFinal)
            {
                duracao = horasFinal - horasInicial;
            }
            else
            {
                duracao = 24 - horasInicial + horasFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

        }
    }
}
