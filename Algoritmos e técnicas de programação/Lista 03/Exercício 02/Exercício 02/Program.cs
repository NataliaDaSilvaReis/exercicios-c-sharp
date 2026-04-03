namespace Exercício_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Leia os elementos de uma matriz 2 x 4
            // e mostre a média dos elementos.

            int linha = 2;
            int coluna = 4;
            int[,] matriz = new int[linha, coluna];

            double media, soma = 0;

            Console.WriteLine("Populando a matriz[2, 4]:");
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write($"Matriz[{i}, {j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    soma = soma + matriz[i, j];
                }
            }

            media = soma / matriz.Length;

            Console.WriteLine();
            Console.Write($"Média dos elementos: {media}");

        }
    }
}
