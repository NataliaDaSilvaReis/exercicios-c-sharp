namespace Lista_01
{
    internal class Program
    {
        static MatrizIncidencia matrizIncidencia;
        static MatrizAdjacencia matrizAdjacencia;
        static ListaAdjacencia listaAdjacencia;



        /// <summary>
        /// Exibe no console o cabeçalho com o grafo G = (V, A).
        /// Também limpa a tela antes de exibir as informações.
        /// </summary>
        static void Cabecalho()
        {
            Console.Clear();

            Console.WriteLine("=====================================================================");
            Console.WriteLine("                            GRAFO G = (V, A)                         ");
            Console.WriteLine("=====================================================================");
            Console.WriteLine("V = { v1, v2, v3, v4, v5 }");
            Console.WriteLine("A = { {v1,v2}, {v1,v3}, {v1,v5}, {v2,v3}, {v2,v4}, {v3,v4}, {v3,v5} }");
            Console.WriteLine("=====================================================================\n");
        }



        /// <summary>
        /// Exibe uma mensagem no console e aguarda o usuário pressionar Enter para continuar.
        /// </summary>
        static void Pausa()
        {
            Console.WriteLine();
            Console.WriteLine("\nDigite ENTER para continuar.");
            Console.ReadKey();
        }



        /// <summary>
        /// Exibe o menu principal do sistema no console e solicita ao usuário
        /// que escolha uma opção.
        /// </summary>
        /// <returns>
        /// Um valor inteiro correspondente à opção escolhida pelo usuário.
        /// </returns>
        static int ExibirMenu()
        {
            Cabecalho();

            Console.WriteLine("************************** MENU PRINCIPAL ***************************");
            Console.WriteLine();
            Console.WriteLine("  [1] Matriz de Adjacência");
            Console.WriteLine("  [2] Matriz de Incidência");
            Console.WriteLine("  [3] Lista de Adjacência");
            Console.WriteLine("  [0] Sair");
            Console.WriteLine();
            Console.WriteLine("*********************************************************************");
            Console.WriteLine();

            int opcao;
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            return opcao;
        }



        /// <summary>
        /// Exibe o submenu de operações relacionadas à matriz de adjacência.
        /// </summary>
        /// <returns>
        /// Número inteiro correspondente à opção selecionada.
        /// </returns>
        static void SubMenuMatrizAdjacencia()
        {
            int escolha;

            do
            {
                Cabecalho();

                Console.WriteLine("*********************** MATRIZ DE ADJACÊNCIA ************************");
                Console.WriteLine();
                Console.WriteLine("  [1] Visualizar matriz");
                Console.WriteLine("  [2] Ver vizinhança de um vértice");
                Console.WriteLine("  [0] Voltar");
                Console.WriteLine();
                Console.WriteLine("*********************************************************************");
                Console.WriteLine();

                Console.Write("Escolha uma opção: ");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        matrizAdjacencia.Imprimir();
                        Pausa();
                        break;
                    case 2:
                        Console.Write("Informe um vértice: ");
                        int vertice = int.Parse(Console.ReadLine());

                        matrizAdjacencia.Vizinhanca(vertice);
                        Pausa();
                        break;
                }
            } while (escolha != 0);
        }



        /// <summary>
        /// Exibe o submenu de operações relacionadas à matriz de incidência.
        /// </summary>
        /// <returns>
        /// Número inteiro correspondente à opção selecionada.
        /// </returns>
        static void SubMenuMatrizIncidencia()
        {
            int escolha;

            do
            {
                Cabecalho();

                Console.WriteLine("*********************** MATRIZ DE INCIDÊNCIA ************************");
                Console.WriteLine();
                Console.WriteLine("  [1] Visualizar matriz");
                Console.WriteLine("  [0] Voltar");
                Console.WriteLine();
                Console.WriteLine("*********************************************************************");
                Console.WriteLine();

                Console.Write("Escolha uma opção: ");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        matrizIncidencia.Imprimir();
                        Pausa();
                        break;
                }
            } while (escolha != 0);
        }



        /// <summary>
        /// Exibe o submenu de operações relacionadas à lista de adjacência.
        /// </summary>
        /// <returns>
        /// Número inteiro correspondente à opção selecionada.
        /// </returns>
        static void SubMenuListaAdjacencia()
        {
            int escolha;

            do
            {
                Cabecalho();

                Console.WriteLine("*********************** LISTA DE ADJACÊNCIA ************************");
                Console.WriteLine();
                Console.WriteLine("  [1] Visualizar listas");
                Console.WriteLine("  [2] Ver vizinhança de um vértice");
                Console.WriteLine("  [0] Voltar");
                Console.WriteLine();
                Console.WriteLine("*********************************************************************");
                Console.WriteLine();

                Console.Write("Escolha uma opção: ");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        listaAdjacencia.Imprimir();
                        Pausa();
                        break;

                    case 2:
                        Console.Write("Informe um vértice: ");
                        int vertice = int.Parse(Console.ReadLine());

                        listaAdjacencia.Vizinhanca(vertice);
                        Pausa();
                        break;
                }
            } while (escolha != 0);
        }

        static void Main(string[] args)
        {
            List<Vertice> vertices = new List<Vertice>
            {
                new Vertice(1),
                new Vertice(2),
                new Vertice(3),
                new Vertice(4),
                new Vertice(5)
            };

            List<Aresta> arestas = new List<Aresta>
            {
                new Aresta(vertices[0], vertices[1]),
                new Aresta(vertices[0], vertices[2]),
                new Aresta(vertices[0], vertices[4]),
                new Aresta(vertices[1], vertices[2]),
                new Aresta(vertices[1], vertices[3]),
                new Aresta(vertices[2], vertices[3]),
                new Aresta(vertices[2], vertices[4]),
            };

            Grafo grafo = new Grafo(vertices, arestas);

            matrizIncidencia = new MatrizIncidencia(grafo);
            matrizAdjacencia = new MatrizAdjacencia(grafo);
            listaAdjacencia = new ListaAdjacencia(grafo);

            int opcao;

            do
            {
                opcao = ExibirMenu();
                switch (opcao)
                {
                    case 1:
                        SubMenuMatrizAdjacencia();
                        break;
                    case 2:
                        SubMenuMatrizIncidencia();
                        break;
                    case 3:
                        SubMenuListaAdjacencia();
                        break;
                }
            } while (opcao != 0);
        }
    }
}
