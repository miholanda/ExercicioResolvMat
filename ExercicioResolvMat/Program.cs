/*
 * Fazer um programa para ler um número inteiro N e uma matriz de ordem N contendo
 * números inteiros. Em seguida, mostrar a diagonal principal e a quantidade de valores
 * negativos da matriz. 
 */

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a ordem da matriz: ");
            int N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[N, N];

            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    Console.Write("Informar elemento da linha " + i + " e coluna " + j + ": ");
                    int elemento = int.Parse(Console.ReadLine());
                    matriz[i, j] = elemento;

                    Console.Clear();
                }
            }

            for(int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                    continue;
                }
                Console.WriteLine();
            }

            int negativos = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if(matriz[i, j] < 0)
                    {
                        negativos += 1;
                    }

                    if(i == j)
                    {
                        Console.WriteLine("Diagonal principal - linha: " + i + " e coluna: " + j + ": " + matriz[i, j]);
                    }
                }
            }

            Console.WriteLine();

            Console.Write("Quantidade de valores negativos na matriz: " + negativos);

            Console.WriteLine();
        }
    }
}