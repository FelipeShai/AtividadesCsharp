using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso
{
    public class List
    {
        public static void Executar()
        {
            List<string> listaNomesColegas = new List<string> { "Túlio", "Alexandre", "João", "Aldair", "Leonardo", "Adrian", "Jubileu" };
            // inicializa                       instancia
            Console.WriteLine("Contagem lista: " + listaNomesColegas.Count);
            Console.WriteLine("-------------------");

            Console.WriteLine("Nomes dentro da lista: ");
            foreach (string obj in listaNomesColegas) { Console.WriteLine(obj); }

            Console.WriteLine("-------------------");
            Console.WriteLine("Adicionando um integrante ao final da lista: Lygia");
            listaNomesColegas.Add("Lygia");

            Console.WriteLine("-------------------");
            Console.WriteLine("Recontagem lista: " + listaNomesColegas.Count);

            Console.WriteLine("-------------------");
            Console.WriteLine("Lista atualizada: ");
            foreach (string obj in listaNomesColegas)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("Adicionando um integrante na segunda posição da lista: Vinicius");
            listaNomesColegas.Insert(1, "Vinicius");

            Console.WriteLine("-------------------");
            Console.WriteLine("Recontagem lista: " + listaNomesColegas.Count);

            Console.WriteLine("-------------------");
            Console.WriteLine("Lista atualizada: ");
            foreach (string obj in listaNomesColegas)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-------------------");

            string findTesteUm = listaNomesColegas.Find(testeFindFuncao);
            Console.WriteLine("Primeiro que começa com A: " + findTesteUm);
            Console.WriteLine("-------------------");

            string findTesteDois = listaNomesColegas.FindLast(x => x[0] == 'A');
            Console.WriteLine("Ultimo nome que começa com A: " + findTesteDois);
            Console.WriteLine("-------------------");

            int posPrimeiro = listaNomesColegas.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posição primeiro nome que comece com a letra A na lista: " + posPrimeiro);
            Console.WriteLine("-------------------");

            int posUltimo = listaNomesColegas.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Posição ultimo nome que comece com a letra A na lista: " + posUltimo);
            Console.WriteLine("-------------------");


            List<string> filtroListaNomesColegas = new List<string> { };
            filtroListaNomesColegas = listaNomesColegas.FindAll(x => x[0] == 'A');

            Console.WriteLine("Filtrando a lista pelos nomes que começam com a letra A");
            foreach (string obj in filtroListaNomesColegas) { 
                Console.WriteLine(obj);
            }
            
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Removendo Adrian");
            listaNomesColegas.Remove("Adrian");
            foreach (string obj in listaNomesColegas)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Removendo nome que esteja na posição 2");
            listaNomesColegas.RemoveAt(2);
            foreach (string obj in listaNomesColegas)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Removendo todos os nomes que começam com J");
            listaNomesColegas.RemoveAll(x => x[0] == 'J');
            foreach (string obj in listaNomesColegas)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Removendo 3 nomes a partir da posição 0");
            listaNomesColegas.RemoveRange(0, 3);
            foreach (string obj in listaNomesColegas)
            {
                Console.WriteLine(obj);
            }
        }

        //predicado é uma função que pega um valor e vai retornar verdadeiro ou falso conforme a lógica dessa função
        static bool testeFindFuncao(string s)
        {
            return s[0] == 'A';
        }
    }
}
