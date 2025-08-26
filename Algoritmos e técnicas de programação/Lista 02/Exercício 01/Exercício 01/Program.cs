namespace Exercício_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita um número ao usuário e verifica se ele é par ou ímpar,
            // além de determinar se é positivo, negativo ou zero.

            double _numero;
            string _paridade = "Ímpar";
            string _sinal = "Zero";


            Console.WriteLine("VERIFICAÇÃO DE NÚMERO - Par / Ímpar | Positivo / Negativo");
            Console.WriteLine("=========================================================");
            Console.WriteLine();

            Console.Write($"Informe o número inteiro que deseja verificar: ");
            _numero = double.Parse(Console.ReadLine());


            if (_numero % 2 == 0)
            {
                _paridade = "Par";
            }

            if (_numero > 0)
            {
                _sinal = "Positivo";
            }
            else if (_numero < 0)
            {
                _sinal = "Negativo";
            }


            Console.WriteLine($"\nResultado");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"\nParidade:    {_paridade}");
            Console.WriteLine($"Sinal:       {_sinal}");
            Console.WriteLine("\nFim do Programa!");
            Console.ReadLine();
        }
    }
}
