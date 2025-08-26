namespace Exercício_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa que lê 4 notas e mostra na tela a soma e a média.
            int _quantNotas = 4;
            double[] _notas = new double[_quantNotas];
            double _soma = 0;
            double _media;

            Console.WriteLine("CÁLCULO DE NOTAS");
            Console.WriteLine("=====================================");
            Console.WriteLine();

            for (int i = 0; i < _quantNotas; i++)
            {
                Console.Write($"Informe a {i + 1}ª nota: ");
                _notas[i] = double.Parse(Console.ReadLine());

                _soma += _notas[i];
            }

            _media = _soma / _quantNotas;

            Console.WriteLine($"\nA soma das notas é: {_soma}");
            Console.WriteLine($"A média aritmética das notas é: {_media:F2}");
            Console.WriteLine("\nFim do Programa!");
            Console.ReadLine();

        }
    }
}
