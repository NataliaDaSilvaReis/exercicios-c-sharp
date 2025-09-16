namespace Exercício_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário as notas de quatro provas, calcula a média com base na soma das notas
            // e informa se o aluno foi aprovado ou reprovado de acordo com o critério de 60% mínimo para aprovação.


            const int QuantAvaliacoes = 4;
            const double PercentualMinAprovacao = 0.6;
            const double ValorProvas = 10;

            double[] notas = new double[QuantAvaliacoes];
            double _soma = 0;
            double _media = 0;
            string _aprovacao = "reprovado";


            Console.WriteLine("VERIFICAÇÃO DE APROVAÇÃO DO ALUNO");
            Console.WriteLine("=================================");
            Console.WriteLine();


            for (int i = 0; i < QuantAvaliacoes; i++)
            {
                Console.Write($"Informe a nota da {i + 1}ª prova: ");
                notas[i] = double.Parse(Console.ReadLine());

                if (notas[i] > ValorProvas || notas[i] < 0)
                {
                    throw new ArgumentOutOfRangeException($"A nota da prova deve ser entre 0 e {ValorProvas}.");
                }

                _soma += notas[i];
            }


            _media = _soma / QuantAvaliacoes;


            if (_soma >= (ValorProvas * QuantAvaliacoes * PercentualMinAprovacao))
            {
                _aprovacao = "aprovado";
            }


            Console.Clear();
            Console.WriteLine("VERIFICAÇÃO DE APROVAÇÃO DO ALUNO");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.WriteLine($"Média das {QuantAvaliacoes} notas do aluno: {_media}");
            Console.WriteLine($"\nO aluno está {_aprovacao}.");


            Console.WriteLine("\nFim do Programa!");
            Console.ReadLine();

        }
    }
}
