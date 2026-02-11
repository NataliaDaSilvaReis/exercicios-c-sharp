namespace Exercício_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Leia os elementos de uma matriz quadrada
            // e mostre os elementos da diagonal principal.

            int tamanho;
            int[,] matriz;

            Console.Write("Informe o tamanho da matriz quadrada: ");
            tamanho = int.Parse(Console.ReadLine());
            matriz = new int[tamanho, tamanho];

            Console.WriteLine();
            Console.WriteLine("Populando a matriz:");
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    Console.Write($"Matriz[{i}, {j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine();
            Console.Write("Diagonal principal: ");
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    if (i == j)
                    {
                        Console.Write($"{matriz[i, j]}  ");
                    }
                }
            }
        }
    }
}