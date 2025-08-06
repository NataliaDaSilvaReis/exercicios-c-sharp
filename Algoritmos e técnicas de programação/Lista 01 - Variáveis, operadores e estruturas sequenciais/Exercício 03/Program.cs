namespace Exercício_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa que lê a idade em anos, meses e dias e a mostra em dias (considerando todos os anos com 365 dias e os meses com 30 dias).
            int _anos, _meses, _dias, _total;

            Console.WriteLine("CÁLCULO DA IDADE EM DIAS");
            Console.WriteLine("=====================================");
            Console.WriteLine();

            Console.Write($"Informe a sua idade em anos, dias e meses. Primeiro digite a quantidade de anos: ");
            _anos = int.Parse(Console.ReadLine());
            Console.Write($"Informe a quantidade de meses: ");
            _meses = int.Parse(Console.ReadLine());
            Console.Write($"Informe a quantidade de dias: ");
            _dias = int.Parse(Console.ReadLine());

            _total = _anos * 365 + _meses * 30 + _dias;

            Console.WriteLine($"\nA sua idade total em dias é: {_total}");
            Console.WriteLine("\nFim do Programa!");
            Console.ReadLine();

        }
    }
}
