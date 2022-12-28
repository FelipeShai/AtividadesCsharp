using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso
{
    class Calculadora
    {
        //MODIFICADOR PARAMS
        //Em vez de criar sobrecargas, você pode utilizar o params para isso.
        public static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Sum(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }
        public static int Sum(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        }

        //Sem usar Params
    public static int Somar(int[] numeros)
    {
        int numero = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            numero += numeros[i];
        }
        return numero;
    }

    public static int SomarUsandoParams(params int[] numeros)
    {
        int numero = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            numero += numeros[i];
        }
        return numero;
    }
    //Executando sem params
    public static void Executar()
    {
        int resultado = Calculadora.Somar(new int[] { 10, 20, 30, 40 });
        Console.WriteLine(resultado);
    }

    //Usando params
    public static void ExecutarSimplificandoUsandoParams()
    {
        int resultado = Calculadora.SomarUsandoParams(10, 20, 30, 40);
        Console.WriteLine(resultado);
    }
    }


}
