/* UNIDADE 2 - Tema 1 - Construtores de Classe
 * Link: https://pucminas.instructure.com/courses/49011/pages/unidade-2-tema-1-construtores-de-classe?module_item_id=1278823
 * Desenvolva uma classe que, por meio de métodos, realize as seguintes operações dentro de um vetor de números inteiros:
Criação de um vetor de dimensões fornecidas pelo usuário segundo um método construtor. Se não for fornecido pelo usuário 
o tamanho deverá ser, por padrão, 10;
Criação de um vetor de dimensões fornecidas pelo usuário e inserção automática de valores aleatórios nesse vetor, 
segundo um método construtor, fornecidos os limites mínimo e máximo; Se não fornecido o tamanho do vetor pelo usuário 
o tamanho deverá ser 10;
Listagem de todos os elementos do vetor;
Inserção de um valor em uma dada posição do vetor;
Recuperação de um valor indicado por uma posição fornecida pelo usuário;
Localização do Maior e do Menor número dentro do vetor.
Teste as rotinas no programa principal (main).
 */
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoUsoClasse
{
    class Vetor
    {
        private int[] V;        // Vetor
        private int Tam;        // Tamanho do Vetor

        public Vetor()          // Construtor
        {
            Tam = 10;           // O usuário não disse o tamanho, o padrão então é 10

            V = new int[Tam];   // Cria o vetor
        }
        public Vetor(int T)     // Outro Construtor
        {
            Tam = T;            // Agora o usuário forneceu o tamanho

            V = new int[Tam];   // Cria o vetor
        }

        public Vetor(int LInf, int LSup)    // Construtor com dois parâmetros
        {
            Tam = 10;                       // Vetor com 10 posições e aleatório

            V = new int[Tam];

            Random x = new Random();

            for (int i = 0; i < 10; i++)
            {
                V[i] = x.Next(LInf, LSup + 1);
            }
        }

        public Vetor(int T, int LInf, int LSup)     // Construtor com 3 parâmetros
        {
            Tam = T;                                // Vetor com T posições e aleatório

            V = new int[Tam];

            Random x = new Random();

            for (int i = 0; i < Tam; i++)
            {
                V[i] = x.Next(LInf, LSup + 1);
            }
        }

        public void Inserir(int Pos, int Valor)
        {
            V[Pos] = Valor;
        }

        public int Recupera(int Pos)
        {
            return V[Pos];
        }

        public int AchaMaior()
        {
            int Maior = V[0];

            for (int i = 1; i < Tam; i++)
            {
                if (V[i] > Maior)
                    Maior = V[i];
            }

            return Maior;
        }

        public int AchaMenor()
        {
            int Menor = V[0];

            for (int i = 1; i < Tam; i++)
            {
                if (V[i] > Menor)
                    Menor = V[i];
            }

            return Menor;
        }

        public void ListarVetor()
        {
            Console.WriteLine();

            foreach (int x in V)
            {
                Console.Write($"{x,5}");
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vetor xVet1 = new Vetor();

            xVet1.ListarVetor();

            xVet1.Inserir(0, 92);
            xVet1.Inserir(2, 45);
            xVet1.Inserir(3, 21);
            xVet1.Inserir(7, 89);

            xVet1.ListarVetor();

            Vetor xVet2 = new Vetor(5);

            xVet2.Inserir(0, 76);
            xVet2.Inserir(2, 12);
            xVet2.Inserir(3, 65);

            xVet2.ListarVetor();

            Vetor xVet3 = new Vetor(8, 1, 50);

            xVet3.ListarVetor();

            Console.WriteLine($"\n   O Elemento da Posição 3 do Vetor é {xVet3.Recupera(3)}");

            Console.ReadKey();
        }
    }
}
