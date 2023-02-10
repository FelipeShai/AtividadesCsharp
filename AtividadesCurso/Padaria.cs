using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso
{
    public class Padaria
    {
        public void Funcionar(IPadeiro padeiro, IPlaca placa)
        {
            Console.WriteLine("Padaria Abriu");
            //placa.InformarPaoDoDia("Pão Francês");
            padeiro.InformarPlaca(placa);
            padeiro.FazerPao();
        }
    }

    public interface IPadeiro
    {
        void FazerPao();
        void InformarPlaca(IPlaca placa);
    }

    public interface IPlaca
    {
        public void InformarPaoDoDia(string texto);
    }



    public class Joao1 : IPadeiro
    {
        private IPlaca? placaJoao;
        public void InformarPlaca(IPlaca placa)
        {
            placaJoao = placa;
        }
        public void FazerPao()
        {
            placaJoao!.InformarPaoDoDia("Pão Francês");
            Console.WriteLine("João faz pão");
        }
    }


    public class Tulio1 : IPadeiro
    {
        private IPlaca? placaTulio;
        public void InformarPlaca(IPlaca placa)
        {
            placaTulio = placa;
        }
        public void FazerPao()
        {
            placaTulio!.InformarPaoDoDia("Pão Italiano");
            Console.WriteLine("Tulio faz pão");
        }
    }

    public class PlacaPaoDoDia : IPlaca
    {
        public void InformarPaoDoDia(string texto)
        {
            Console.WriteLine(texto);
        }
    }
}
