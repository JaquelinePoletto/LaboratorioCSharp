using System;
using System.IO;

namespace ConsoleApp1
{
    
    class Program
    {
        // Arquivo para escrita
        static StreamWriter arquivo;
        static void DemoInc()
        {
            int preInc = 7, posInc = 7, preDec = 7, posDec = 7;
            Console.WriteLine($"1o. preInc = { preInc}");
            Console.WriteLine($"1o. posInc = { posInc}");
            Console.WriteLine($"preInc = { ++preInc}");
            Console.WriteLine($"posInc = { posInc++}");
            Console.WriteLine($"2o. preInc = { preInc}");
            Console.WriteLine($"2o. posInc = { posInc}");
            Console.WriteLine();
            Console.WriteLine($"1o. preDec = { preDec}");
            Console.WriteLine($"1o. posDec = { posDec}");
            Console.WriteLine($"preDec = { --preDec}");
            Console.WriteLine($"posDec = { posDec--}");
            Console.WriteLine($"2o. preDec = { preDec}");
            Console.WriteLine($"2o. posDec = { posDec}");
        }

        static void FuncoesMatematicas()
        {
            Console.WriteLine($"3 elevado a 4: {Math.Pow(3, 4)}");
            Console.WriteLine($"Rais quadrada de 81: {Math.Sqrt(81)}");
            Console.WriteLine($"Rais cúbica de 27: {Math.Pow(27, 1 / 3.0)}");
        }

        static void FuncaoQuadratica()
        {
            double x1, x2, a, b, c, delta;

            /* exemplo: f(x) = x²+ 2x -3 */
            a = 1; b = 2; c = -3;
            delta = Math.Pow(b, 2) - 4 * a * c;

            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("Valor de delta: {0}", delta);
            Console.WriteLine("Raizes da equação: {0}", x1);
            Console.WriteLine("Raizes da equação: {0}", x2);
        }

        static void CalculaMedia()
        {
            double n1, n2, n3, media;

            Console.Write("Digite o número 1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o número 2: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o número 3: ");
            n3 = int.Parse(Console.ReadLine());

            double soma = (n1 + n2 + n3);
            media = soma / 3;
            Console.WriteLine("Soma dos 3 números: {0}", soma);
            Console.WriteLine("Valor da média dos 3 números: {0}", media);
            Console.WriteLine($"Média com máscara: {media:0.00}");
        }

        static void contador()
        {
            int x = 5, y = 2, cont = 0;

            do
            {
                x += 1;
                y += 2;
                cont++;
            } while (x > y);
            Console.WriteLine("Valor de cont: {0}", cont);
        }

        static void UseFor()
        {
            for (int i = 3; i < 8; i++)
                for (int j = 5; j > 1; j--)
                {
                    Console.WriteLine("{0} - {1}", i, j);
                    i++;
                }
        }

        static void UseTernario() {

            int a = 5, b = 10;

            int x = (a <= 10 ? a++ + b : ++b - a);

            Console.WriteLine("Valor de x: {0}", x);

        }

        static void TesteIf()
        {
            int a = 13, b = 7;

            if (a < b)
                if (a < 15)
                    Console.WriteLine("Resp 1");
                else
                    Console.WriteLine("Resp 2");

        }

        static double CalculaPerc(double Vlr, double perc, ref double VlrCalc)
        {
            VlrCalc = (Vlr * (perc / 100));
            return VlrCalc;
        }

        static void TestaProcedure()
        {
            double VlrCalcRef=0;

            double VlrCalculado = CalculaPerc(500.0, 25.0, ref VlrCalcRef);
            Console.WriteLine("perc calculado: {0}", VlrCalculado);
            Console.WriteLine("perc calculado por referência: {0}", VlrCalcRef);
        }

        static void CriaArquivoTexto()
        {
            StreamWriter sw = new StreamWriter(@"c:\tmp\MeuArquivo.txt");
            sw.WriteLine("Este é o meu primeiro arquivo em C#");
            sw.WriteLine("Segunda Linha do Arquivo");
            sw.Close();
            Console.WriteLine("Criei o arquivo txt");
        }

        static void LeArquivoTexto()
        {
            StreamReader sr = new StreamReader(@"c:\tmp\MeuArquivo.txt");
            String Linha = sr.ReadLine();
            Console.WriteLine("Opções de uso:");
            while (Linha != null)
             {             
                Console.WriteLine("Valor Lido: {0}", Linha);
                Console.WriteLine("Valor Lido (Upper): {0}", Linha.ToUpper());
                Console.WriteLine("Valor Lido (Lower): {0}", Linha.ToLower());
                Linha = sr.ReadLine();
            }
            sr.Close();
        }

        static void AbreArquivo(string Path)
        {
            arquivo = new StreamWriter(@Path, false);
        }

        static void FechaArquivo()
        {
            arquivo.Close();
        }

        static void GravaDados(string nome, char sexo, int idade, Double peso, Double altura)
        {
            String sep = ";";
            arquivo.Write(nome+sep);
            arquivo.Write(sexo+sep);
            arquivo.Write(idade+sep);
            arquivo.Write(peso+sep);
            arquivo.WriteLine(altura+sep);
        }

        static void GravaDadosFile()
        {
            // Abrindo arquivo para gravação
            AbreArquivo(@"C:\tmp\arq2.csv");
            // Gravando dados do João da Silva (nome, sexo, idade, peso, altura)
            GravaDados("João da Silva", 'M', 45, 85, 1.78);

            // Gravando dados do Maria José (nome, sexo, idade, peso, altura)
            GravaDados("Maria José", 'F', 53, 72, 1.69);

            // Gravando dados do Carlos Eudardo (nome, sexo, idade, peso, altura)
            GravaDados("Carlos Eduardo", 'M', 28, 81, 1.83);

            FechaArquivo();
        }

        static void LeDadosFile()
        {
            StreamReader sr = new StreamReader(@"C:\tmp\arq2.csv");
            String Linha = sr.ReadLine();
            String[] Vet = new string[5];

            while (Linha != null)
            {
                Console.WriteLine("Linha Completa: {0}", Linha);
                Vet = Linha.Split(';', StringSplitOptions.None);
                Console.WriteLine("Nome: {0} - Sexo: {1} - Idade: {2} - Peso: {3} - Altura: {4}", Vet[0], Vet[1], Vet[2], Vet[3], Vet[4]);
                Linha = sr.ReadLine();
            }
            sr.Close();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*Console.Write("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("A sua idade é {0}", idade);

            Console.WriteLine("1/3 da idade: {0}", (idade / 3));
            Console.WriteLine("1/3 da idade com ponto flutuante: {0}", (idade / 3.0));*/

            /* DemoInc(); */

            //FuncoesMatematicas();
            //FuncaoQuadratica();
            //CalculaMedia();
            //UseFor();
            //UseTernario();
            //TesteIf();
            //contador();
            //TestaProcedure();
            //CriaArquivoTexto();
            //LeArquivoTexto();
            //GravaDadosFile();
            LeDadosFile();
        }
    }
}
