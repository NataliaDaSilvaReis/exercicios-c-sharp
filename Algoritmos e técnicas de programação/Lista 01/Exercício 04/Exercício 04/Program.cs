namespace Exercício_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Calcula a distância percorrida em queda livre por um objeto dado um tempo em segundos, desconsiderando qualquer resistência (d = 1/2 g t² e g = 9,81m/s²).
            double _distancia;
            int _tempo;
            const double _gravidade = 9.81;

            Console.WriteLine("CÁLCULO DA DISTÂNCIA");
            Console.WriteLine("=====================================");
            Console.WriteLine();

            Console.Write($"Informe o tempo em segundos: ");
            _tempo = int.Parse(Console.ReadLine());

            _distancia = 1 / 2 * _gravidade * Math.Pow(_tempo, 2);

            Console.WriteLine($"\nA distância percorrida em queda livre pelo objeto é: {_distancia}");
            Console.WriteLine("\nFim do Programa!");
            Console.ReadLine();

        }
    }
}
