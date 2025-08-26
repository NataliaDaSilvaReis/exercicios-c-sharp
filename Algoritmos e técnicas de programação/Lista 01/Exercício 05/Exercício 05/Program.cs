namespace Exercício_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calcular o valor de uma compra a partir de produtos pré-estabelecidos, variando seus preços e quantidades. Considerando: quantidade de latas de chocolate em pó a um custo unitário, litros de leite a um custo unitário e quilos de banana a um custo unitário.
            int _quantChocolate; 
            double _quantLeite, _quantBanana, _precoChocolate, _precoLeite, _precoBanana, _totalChocolate, _totalLeite, _totalBanana, _totalCompra;

            Console.WriteLine("CÁLCULO COMPRAS DO SUPERMERCADO");
            Console.WriteLine("===============================");
            Console.WriteLine();

            Console.Write($"Informe a quantidade de latas de chocolate em pó compradas: ");
            _quantChocolate = int.Parse(Console.ReadLine());
            Console.Write($"Informe o preço das latas de chocolate em pó: R$");
            _precoChocolate = double.Parse(Console.ReadLine());

            Console.Write($"\nInforme quantos litros de leite comprados: ");
            _quantLeite = double.Parse(Console.ReadLine());
            Console.Write($"Informe o preço do litro de leite: R$");
            _precoLeite = double.Parse(Console.ReadLine());

            Console.Write($"\nInforme quantos quilos de banana comprados: ");
            _quantBanana = double.Parse(Console.ReadLine());
            Console.Write($"Informe o preço do quilo de banana: R$");
            _precoBanana = double.Parse(Console.ReadLine());

            _totalChocolate = _quantChocolate * _precoChocolate;
            _totalLeite = _quantLeite * _precoLeite;
            _totalBanana = _quantBanana * _precoBanana;
            _totalCompra = _totalChocolate + _totalLeite + _totalBanana;


            Console.Clear();
            Console.WriteLine("CÁLCULO COMPRAS DO SUPERMERCADO");
            Console.WriteLine("===============================");
            Console.WriteLine();
            Console.WriteLine($"Valor total - Latas de Chocolate em Pó  =    R${_totalChocolate:F2}");
            Console.WriteLine($"Valor total - Litros de Leite           =    R${_totalLeite:F2}");
            Console.WriteLine($"Valor total - Quilos de Banana          =    R${_totalBanana:F2}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"\nValor total da compra                   =    R${_totalCompra:F2}");
            Console.WriteLine("\nFim do Programa!");
            Console.ReadLine();
        }
    }
}
