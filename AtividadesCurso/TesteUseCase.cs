using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso
{
    //Verificar se o número bilhete é valido
    //Se não for válido, retornar código de Erro 0
    //Verificar se o serviço externo de checagem do bilhete está disponível
    //Se o serviço externo não estiver disponível, retorna código de erro 1
    //Verificar se o bilhete está premiado
    //Se o bilhete está premiado, retornar true, se não, uma string para comprar mais bilhetes
    public class TesteUseCase
    {
        ResultadoOutputPort resultadoOutputPort;
        public TesteUseCase(ResultadoOutputPort outputPort)
        {
            resultadoOutputPort = outputPort;
        }
        public void VerificarNumerosBilhetes(int numeroBilhetes)
        {
            if (numeroBilhetes == 0)
            {
                resultadoOutputPort.SetarErroInvalido();
                return;
            }

            if (numeroBilhetes == 1)
            {
                resultadoOutputPort.SetarErroIndisponivel();
                return;
            }

            if (numeroBilhetes == 2)
            {
                resultadoOutputPort.SetarBilhetePremiado();
                return;
            }

            if (numeroBilhetes == 3)
            {
                resultadoOutputPort.SetarNaoPremiado();
                return;
            }
        }
    }

    public class ResultadoOutputPort
    {
        public bool Premiado = false;
        public bool Erro = false;
        public string Mensagem = "";
        public bool NaoPremiado = false;
        public int CodigoErro = -1;

        public void SetarBilhetePremiado()
        {
            Premiado = true;
        }

        public void SetarErroInvalido()
        {
            Erro = true;
            CodigoErro = 0;
        }

        public void SetarErroIndisponivel()
        {
            Erro = true;
            CodigoErro = 1;

        }

        public void SetarNaoPremiado()
        {
            NaoPremiado = true;
            Mensagem = "www.google.com";
        }
    }
}
