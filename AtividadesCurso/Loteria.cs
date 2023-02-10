using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso
//Verificar se o número bilhete é valido
//Se não for válido, retornar código de Erro 0
//Verificar se o serviço externo de checagem do bilhete está disponível
//Se o serviço externo não estiver disponível, retorna código de erro 1
//Verificar se o bilhete está premiado
//Se o bilhete está premiado, retornar true, se não, uma string para comprar mais bilhetes

{
    public class Loteria
    {  
        public void VerificarBilheteLoteria(int numeroBilhete)
        {
            if(numeroBilhete == 0)
            {
                Console.WriteLine("Bilhete inválido");
            }

            if(numeroBilhete == 1)
            {
                Console.WriteLine("Serviço externo indisponível");
            }

            if(numeroBilhete == 2)
            {
                Console.WriteLine("Parabéns, você ganhou");
            }

            if(numeroBilhete == 3)
            {
                Console.WriteLine("Você não ganhou, compre mais");
            }
        }
    }
    public class OutPutportLoteria
    {
        public bool Premiado = false;
        public bool Erro = false;
        public string Mensagem = "";
        public bool NaoPremiado = false;
        public int CodigoErro = -1;
    }
}
