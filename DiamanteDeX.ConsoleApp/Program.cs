namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                int numero = Validacao.EntradaUsuario();
                Desenhar desenhar = new Desenhar();
                desenhar.DesenharTriangulo(numero);
                Console.ReadLine();
                break;
            }
        }
    }
}