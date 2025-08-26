namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calcular a quantidade de casas populares a serem construídas a partir da verba disponibilizada pelo governo. Considerando: valor da verba igual a US$ 10.000.000,00, cotação do dólar como US$ 1,00 = R$5,41, valor do salário mínimo informado pelo usuário e custo de cada casa equivalente a 150 salários mínimos.
            const int CustoCasaEmSalariosMin = 150;
            const double Verba = 10000000;
            const double CotacaoDolar = 5.41;

            double _salarioMin, _verbaEmReais, _custoCasa, _quantTotalCasas;


            Console.WriteLine("CÁLCULO DE CASAS POPULARES - Construtora Solidez Engenharia S.A.");
            Console.WriteLine("================================================================");
            Console.WriteLine();
            Console.WriteLine("O governo liberou US$ 10.000.000,00 de verba para o projeto.");
            Console.WriteLine("Descubra aqui quantas casas populares podem ser construídas.");

            Console.Write($"\nInforme o valor do salário mínimo atual em reais para realizar o cálculo: R$");
            _salarioMin = double.Parse(Console.ReadLine());


            _verbaEmReais = Verba * CotacaoDolar;
            _custoCasa = CustoCasaEmSalariosMin * _salarioMin;
            _quantTotalCasas = _verbaEmReais / _custoCasa;


            Console.Clear();
            Console.WriteLine("CÁLCULO DE CASAS POPULARES - Construtora Solidez Engenharia S.A.");
            Console.WriteLine("================================================================");
            Console.WriteLine();
            Console.WriteLine($"Verba para o projeto - US$ {Verba:N2}");
            Console.WriteLine($"Cada casa custa o equivalente a {CustoCasaEmSalariosMin} salários mínimos.");
            Console.WriteLine($"Cotação considerada - US$ 1,00 = R$ {CotacaoDolar:F2}");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine($"\nQuantidade total de casas que podem ser construídas:    {(int)_quantTotalCasas} casas");
            Console.WriteLine("\nFim do Programa!");
            Console.ReadLine();

        }
    }
}
