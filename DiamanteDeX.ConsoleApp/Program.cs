namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int numero = Validacao.EntradaUsuario();
                Desenhar desenhar = new Desenhar();
                desenhar.DesenharTriangulo(numero);
                Console.Write("\nDeseja desenhar outro diamante? (S/N): ");
                if (Console.ReadLine().ToUpper() != "S")
                    break;
            }
        }
    }
}