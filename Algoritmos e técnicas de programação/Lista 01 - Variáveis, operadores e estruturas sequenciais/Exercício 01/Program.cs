namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double _pi = 3.14d;
            double _raio, _perimetro;

            Console.WriteLine("CÁLCULO DO PERÍMETRO - CIRCUNFERÊNCIA");
            Console.WriteLine("=====================================");
            Console.Write("\nInforme um número positivo para o raio: ");
            _raio = double.Parse(Console.ReadLine());

            _perimetro = 2 * _pi * _raio;

            Console.WriteLine($"\nO perímetro da circunferência é: {_perimetro:F2}");
            Console.WriteLine("\nFim do Programa!");
            Console.ReadLine();

        }
    }
}
