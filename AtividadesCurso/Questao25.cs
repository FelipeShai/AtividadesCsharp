using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso
{

    public class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
    public class Questao25
    {
        //A dona de um pensionato possui dez quartos para alugar para estudantes,
        //sendo esses quartos identificados pelos números 0 a 9.
        //Quando um estudante deseja alugar um quarto, deve - se registrar o nome
        //e email deste estudante.
        //Fazer um programa que inicie com todos os dez quartos vazios, e depois
        //leia uma quantidade N representando o número de estudantes que vão
        //alugar quartos(N pode ser de 1 a 10).Em seguida, registre o aluguel dos
        //N estudantes. Para cada registro de aluguel, informar o nome e email do
        //estudante, bem como qual dos quartos ele escolheu(de 0 a 9).Suponha
        //que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
        //um relatório de todas ocupações do pensionato, por ordem de quarto,
        //conforme exemplo.

        public static void Executar()
        {
            Estudante[] vetor = new Estudante[10];
            Console.WriteLine("Quantos quartos serão alugados?");
            int numeroQuartos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numeroQuartos; i++)
            {
                Console.WriteLine("----------------");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vetor[quarto] = new Estudante(nome, email);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Quartos alugados:");
            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] != null)
                {
                    Console.WriteLine($"Quarto #{i}");
                    Console.WriteLine("Nome: " + vetor[i].Nome);
                    Console.WriteLine("Email: " + vetor[i].Email);
                    Console.WriteLine("-------------------");
                }
            }
        }
    }
}
