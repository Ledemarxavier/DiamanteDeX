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
        }

        public static void DesenharParteSuperior(int numero)
        {
        }

        public static void DesenharParteInferior(int numero)
        {
        }

        public static void DesenharLinha(int total, int quantidadeDeX)
        {
            int espacos = (total - quantidadeDeX) / 2;

            string espacosStr = new string(' ', espacos);
            string xStr = new string('X', quantidadeDeX);
        }
    }
}