using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso
{
    static class Questao6
    {
        public static void Executar()
        {
            //exercicios1-estrutura-sequencial;
            //questão 6
            /*Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre: 
            a) a área do triângulo retângulo que tem A por base e C por altura. 
            b) a área do círculo de raio C. (pi = 3.14159) 
            c) a área do trapézio que tem A e B por bases e C por altura. 
            d) a área do quadrado que tem lado B. 
            e) a área do retângulo que tem lados A e B*/
            Console.WriteLine("Digite três valores numéricos");
            string valores = Console.ReadLine();
            string[] valoresArray = valores.Split(' ');
            double A = double.Parse(valoresArray[0], CultureInfo.InvariantCulture);
            double B = double.Parse(valoresArray[1], CultureInfo.InvariantCulture);
            double C = double.Parse(valoresArray[2], CultureInfo.InvariantCulture);
            double resultadoTriangulo = areaTriangulo(A, C);
            double resultadoCirculo = areaCirculo(C);
            double resultadoTrapezio = areaTrapezio(A, B, C);
            double resultadoQuadrado = areaQuadrado(B);
            double resultadoRetangulo = areaRetangulo(A, B);

            Console.WriteLine($"Área do triangulo: {resultadoTriangulo.ToString("F3",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área do círculo: {resultadoCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área do trapézio: {resultadoTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área do quadrado: {resultadoQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área do retangulo: {resultadoRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
        static double areaTriangulo(double A, double C)
        {
            return (A * C) / 2;
        }
        static double areaCirculo(double C)
        {
            return 3.14159 * Math.Pow(C, 2);
        }

        static double areaTrapezio(double A, double B, double C)
        {
            return (A + B) * C / 2;
        }
        static double areaQuadrado(double B)
        {
            return Math.Pow(B, 2);
        }

        static double areaRetangulo(double A, double B)
        {
            return A * B;
        }
    }
}

