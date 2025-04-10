using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamanteDeX.ConsoleApp
{
    internal class Validacao
    {
        //método para verificar se a entrada do usúario é válida.
        public static void entradaUsuario()

        {
            while (true)
            {
                Console.WriteLine("Digite um número ímpar para desenhar seu triângulo de X: ");
                string entrada = Console.ReadLine();

                if (int.Parse(entrada) == 1) //o 1 número é ímpar, mas não é válido para desenhar o triângulo.
                {
                    mensagemDeErro();
                    continue;
                }
                else if (!entrada.All(char.IsDigit)) //permite apenas dígito.
                {
                    mensagemDeErro();
                    continue;
                }
                else if (int.Parse(entrada) % 2 == 0) //permite apenas número inteiro ímpar.
                {
                    mensagemDeErro();
                    continue;
                }
                break;
            }
        }

        public static void mensagemDeErro()
        {
            Console.WriteLine("ERRO: Entrada inválida! Digite apenas número ímpar > 1.");
        }
    }
}