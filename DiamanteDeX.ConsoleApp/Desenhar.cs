using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DiamanteDeX.ConsoleApp
{
    internal class Desenhar
    {
        public void DesenharTriangulo(int numero)
        {
            //Desenha as duas parte do triângulo, superior e inferior.
            DesenharParteSuperior(numero);
            DesenharParteInferior(numero);
        }

        public static void DesenharParteSuperior(int numero)
        {
            // Desenha a parte superior, incrementanto os X de 2 em 2.
            for (int i = 1; i <= numero; i += 2)
            {
                DesenharLinha(numero, i);
            }
        }

        public static void DesenharParteInferior(int numero)
        {
            // Desenha a parte inferior, decrementando os X de 2 em 2
            for (int i = numero - 2; i >= 1; i -= 2)
            {
                DesenharLinha(numero, i);
            }
        }

        public static void DesenharLinha(int total, int quantidadeDeX)
        {
            // Calcula a quantidade de espaços para centralizar os X.
            int espacos = (total - quantidadeDeX) / 2;

            string espacosStr = new string(' ', espacos);
            string xStr = new string('X', quantidadeDeX);

            Console.Write(espacosStr);
            Console.WriteLine(xStr);
        }
    }
}