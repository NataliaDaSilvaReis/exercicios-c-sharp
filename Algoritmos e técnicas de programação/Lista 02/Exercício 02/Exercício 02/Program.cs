namespace Exercício_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário os valores de a, b e c da equação quadrática (ax2 + bx + c = 0),
            // verifica se a equação possui raízes reais e, caso possua,
            // calcula e exibe as raízes.


            double _a, _b, _c, _delta, _x1 = 0, _x2 = 0;
            string _raizes = "Não há raiz real.";


            Console.WriteLine("EQUAÇÃO QUADRÁTICA");
            Console.WriteLine("==================");
            Console.WriteLine();

            Console.Write($"Informe o valor de a: ");
            _a = double.Parse(Console.ReadLine());
            Console.Write($"Informe o valor de b: ");
            _b = double.Parse(Console.ReadLine());
            Console.Write($"Informe o valor de c: ");
            _c = double.Parse(Console.ReadLine());


            _delta = (_b * _b) - (4 * _a * _c);


            if (_delta > 0)
            {
                _raizes = "Há duas raízes reais e distintas.";
                _x1 = (-_b + Math.Sqrt(_delta)) / (2 * _a);
                _x2 = (-_b - Math.Sqrt(_delta)) / (2 * _a);
            }
            else if (_delta == 0)
            {
                _raizes = "Há duas raízes reais e iguais.";
                _x1 = (-_b + Math.Sqrt(_delta)) / (2 * _a);
                _x2 = _x1;
            }


            Console.Clear();
            Console.WriteLine("EQUAÇÃO QUADRÁTICA");
            Console.WriteLine("==================");
            Console.WriteLine();
            Console.WriteLine("Valores fornecidos:");
            Console.WriteLine($"a: {_a}");
            Console.WriteLine($"b: {_b}");
            Console.WriteLine($"c: {_c}");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"\nResultado:");
            Console.WriteLine($"\nDelta   =   {_delta}");
            Console.WriteLine($"Raízes  =   {_raizes}");


            if (_raizes != "Não há raiz real.")
            {
                Console.WriteLine($"x'      =   {_x1}");
                Console.WriteLine($"x''     =   {_x2}");
            }

            Console.WriteLine("\nFim do Programa!");
            Console.ReadLine();

        }
    }
}
