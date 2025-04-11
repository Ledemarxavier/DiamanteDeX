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
        public static int EntradaUsuario()

        {
            while (true)
            {
                Console.WriteLine("Digite um número ímpar para desenhar seu triângulo de X: ");
                string entrada = Console.ReadLine();

                if (!entrada.All(char.IsDigit)) //permite apenas dígito.
                {
                    MensagemDeErro();
                    continue;
                }

                int numero = int.Parse(entrada);

                if (numero == 1) //o 1 número é ímpar, mas não é válido para desenhar o triângulo.
                {
                    MensagemDeErro();
                    continue;
                }
                else if (numero % 2 == 0) //permite apenas número inteiro ímpar.
                {
                    MensagemDeErro();
                    continue;
                }
                return numero;
            }
        }

        public static void MensagemDeErro()
        {
            Console.WriteLine("ERRO: Entrada inválida! Digite apenas número ímpar > 1.");
        }
    }
}