using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso
{
    public class Cafeteria
    {
        public void Operar(IDonoCafeteria dono, IGarcom garcom, ICliente cliente)
        {
            dono.AbirCafeteria();
            garcom.AtendeClientes(cliente);
            dono.Cochila();
            cliente.BebeCafe();
            cliente.DaGorgetaParaGarcom(garcom);
            cliente.VaiEmbora();
            garcom.LimpaTudo();
        }
    }
    public interface IDonoCafeteria
    {
        void AbirCafeteria();
        public void Cochila();
    }

    public class Tulio : IDonoCafeteria
    {
        public void AbirCafeteria()
        {
            Console.WriteLine("Dono Túlio abre a Cafeteria");
        }

        public void Cochila()
        {
            Console.WriteLine("Dono cochila o dia todo");
        }
    }


    public interface IGarcom
    {
        public void AtendeClientes(ICliente cliente);
        public void LimpaTudo();
    }

    public class Shai : IGarcom
    {
        public void AtendeClientes(ICliente cliente)
        {
            Console.WriteLine("Garçom atende clientes");
        }
        public void LimpaTudo()
        {
            Console.WriteLine("Garçom limpa tudo");
        }
    }

    public interface ICliente
    {
        public void BebeCafe();
        public void DaGorgetaParaGarcom(IGarcom garcom);
        public void VaiEmbora();
    }
    public class Cliente : ICliente
    {
        public void BebeCafe()
        {
            Console.WriteLine("Cliente bebe Café");
        }
        public void DaGorgetaParaGarcom(IGarcom garcom)
        {
            Console.WriteLine("Cliente dá gorgeta para o garçom");
        }
        public void VaiEmbora()
        {
            Console.WriteLine("Cliente vai embora");
        }
    }
}
