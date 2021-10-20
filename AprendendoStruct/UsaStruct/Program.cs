using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* UNIDADE 1 - Tema 1 - Estruturas Heterogêneas
 * Faça um programa com um menu de opções que possa cadastrar o nome, o preço unitário,
 * a quantidade em estoque e a data de validade (mês e ano) de 30 produtos. Depois dos dados serem informados, 
 * o programa deve conter uma opção que, por meio de uma função, possa listar os produtos acima de um determinado 
 * valor fornecido pelo usuário.
 * Repita o programa anterior, agora considerando que a data de validade é de um tipo estruturado e formado pelos campos mês e ano.
 * Link: https://pucminas.instructure.com/courses/49011/pages/unidade-1-tema-1-estruturas-heterogeneas?module_item_id=1475062
 * 
 */

namespace UsaStruct
{
    // Cadastro do nome, o preço unitário, a quantidade em estoque e a data de validade
    // de 30 produtos.

    // Listar os produtos acima de um determinado valor fornecido pelo usuário.

    struct Produto
    {
        public string Nome;
        public double PreçoUnit;
        public int QtdeEstoque;
        public Data Validade;
    }

    struct Data
    {
        public string Mês;
        public string Ano;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Produto[] CadProd = new Produto[5];

            int Op;

            do
            {
                Console.Clear();

                Console.WriteLine("Opções:\n");

                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Listar Produtos em Estoque");
                Console.WriteLine("3 - Sair");

                Console.Write("\nDigite a Opção: ");
                Op = int.Parse(Console.ReadLine());

                switch (Op)
                {
                    case 1:
                        Cadastrar(CadProd);
                        break;
                    case 2:
                        Listar(CadProd);
                        break;
                    case 3:
                        Console.WriteLine("Saída do Programa...");
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.WriteLine("\nOpção Inválida!!");
                        Thread.Sleep(2000);
                        break;
                }
            } while (Op != 3);
        }

        static void Cadastrar(Produto[] P)
        {
            Console.Clear();

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"\nNome do Produto {i + 1}: ");
                P[i].Nome = Console.ReadLine();

                Console.Write("Preço Unitário (R$).....: ");
                P[i].PreçoUnit = double.Parse(Console.ReadLine());

                Console.Write("Quantidade em Estoque...: ");
                P[i].QtdeEstoque = int.Parse(Console.ReadLine());

                Console.Write("Data de Validade - Mês..: ");
                P[i].Validade.Mês = Console.ReadLine();

                Console.Write("                   Ano..: ");
                P[i].Validade.Ano = Console.ReadLine();
            }
        }

        static void Listar(Produto[] P)
        {
            double Preço;

            Console.Clear();

            Console.Write("Digite o Preço do Produto (Filtro): ");
            Preço = double.Parse(Console.ReadLine());

            /*for (int i = 0; i < 5; i++)
            {
                if (P[i].PreçoUnit >= Preço)
                {
                    Console.WriteLine($"\n{P[i].Nome}");
                    Console.WriteLine($"Preço Unitário (R$) {P[i].PreçoUnit:F2}");
                    Console.WriteLine($"Quantidade em Estoque: {P[i].QtdeEstoque} ");
                    Console.WriteLine($"Vencimento: {P[i].Validade.Mês}/{P[i].Validade.Ano}");
                }
            }*/
            // Substituindo o for acima pelo foreach (amobos funcionam)

            foreach (Produto x in P)
            {
                if (x.PreçoUnit >= Preço)
                {
                    Console.WriteLine($"\n{x.Nome}");
                    Console.WriteLine($"Preço Unitário (R$) {x.PreçoUnit:F2}");
                    Console.WriteLine($"Quantidade em Estoque: {x.QtdeEstoque} ");
                    Console.WriteLine($"Vencimento: {x.Validade.Mês}/{x.Validade.Ano}");
                }
            }
            Console.ReadKey();
        }
    }
}

