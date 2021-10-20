using System;

namespace ConsoleApp2
{
    class Program
    {
        static int SomaPares(int[] Vetor)
        {
            int Result=0;

            for (int i = 0; i < Vetor.Length; i++)
            {
                if ((Vetor[i] % 2) == 0)
                  Result += Vetor[i];
            }

            return Result;
        }

        static int ContaImpares(int[] Vetor)
        {
            int Result = 0;

            for (int i = 0; i < Vetor.Length; i++)
            {
                if ((Vetor[i] % 2) != 0)
                    Result++;
            }

            return Result;
        }
        static void UsaVetor ()
        {
            int[] Vetor = new int[5];

            for (int i=0; i<5; i++)
            {
                Console.Write($"Digite o {i+1}o. elemento do vetor: ");
                Vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Soma dos números pares: {0}", SomaPares(Vetor));
            Console.WriteLine("Quantidade números ímpares: {0}", ContaImpares(Vetor));
            
        }

        static int[] DiagonalPrincipal(int[,] Matrix)
        {
            int[] Result = new int[5];
            //int cont = 0;

            /*for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                        Result[cont++] = Matrix[i, j];
                } */
            // Como os elementos da diagonal principal ocorrem quando i=j, o código acima pode ser reescrito:
            for (int i = 0; i < 5; i++)
                Result[i] = Matrix[i, i];

            return Result;
        }
        static void UsaMatriz()
        {
            int[,] Matrix = new int[5, 5];
            int[] Vetor;

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Digite o elemento [{i + 1},{j+1}] da matriz: ");
                    Matrix[i, j] = int.Parse(Console.ReadLine());
                }

            Vetor = DiagonalPrincipal(Matrix);

            Console.WriteLine("Elementos da Matriz: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{Matrix[i, j], 7}"); // formata a saída para 7 posições
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Elementos da Diagonal Principal: ");
            for (int k = 0; k < 5; k++)
            {
                Console.Write($"{Vetor[k], 7}"); // formata a saída para 7 posições
            }
        }

        static void InfoVetor(int[] Vetor, ref int Maior, ref int Menor, ref double Media)
        {
            Maior = Vetor[0];            
            Menor = Vetor[0];
            Media = 0;

            for (int i = 0; i < Vetor.Length; i++)
            {
                if (Vetor[i] > Maior)
                    Maior = Vetor[i];
                if (Vetor[i] < Menor)
                    Menor = Vetor[i];
                Media = Media + Vetor[i];
            }
            Media = Media / Vetor.Length;
        }

        static void UsaVetor2()
        {
            int[] Vetor = new int[5];            
            int Maior=0, Menor=0;
            double Media=0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite o {i + 1}o. elemento do vetor: ");
                Vetor[i] = int.Parse(Console.ReadLine());
            }
            // Atenção: Obrigatório inicializar as variáveis por referência. Feito acima.
            InfoVetor(Vetor, ref Maior, ref Menor, ref Media);
            Console.WriteLine("Maior número: {0}", Maior);
            Console.WriteLine("Menor número: {0}", Menor);
            Console.WriteLine("Média: {0}", Media);
            Console.WriteLine("Quantidade números ímpares: {0}", ContaImpares(Vetor));

        }

        static void SomaColunaMatriz()
        {
            int[,] Matrix = new int[3, 5];
            int cont = 1;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 5; j++)
                {
                    Matrix[i, j] = cont;
                    cont++;
                }

            for (int i = 0; i < 5; i++)
            {
                int Soma = 0;
                for (int j = 0; j < 3; j++)
                {
                    Soma += Matrix[j, i];
                }
                Console.WriteLine($"Soma {Soma}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //UsaVetor();
            //UsaMatriz();
            //UsaVetor2();

            SomaColunaMatriz();
        }
    }
}
