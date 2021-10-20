using System;

namespace ProvaInter2App
{
    class Program
    {
        static void Pergunta1()
        {
            int num = 0, cont1 = 0, cont2 = 0;

            do
            {
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    cont1++;
                }
                else
                {
                    cont2++;
                }
            } while (num != 0);
            Console.WriteLine($"Contador 1 = {cont1}, Contador 2 = {cont2}");
        }

        static int funcao1(int x, int y)
        {
            int resultado = 1;

            for (int i = 0; i < y; i++)
            {
                resultado *= x;
            }
            return resultado;
        }

        static int funcao2(int x, int y)
        {
            int resultado = 1;

            for (int i = 0; i < x; i++)
            {
                resultado *= y;
            }
            return resultado;
        }

        static int funcao3(int x, int y)
        {
            int resultado = 1;

            resultado *= x * y;

            return resultado;
        }
        static void Pergunta2()
        {
            int a = 1, b = 3;

            int res1 = funcao1(a, b);
            Console.WriteLine($"Resultado1 = {res1}");

            int res2 = funcao2(a, b);
            Console.WriteLine($"Resultado2 = {res2}");

            int res3 = funcao3(a, b);
            Console.WriteLine($"Resultado3 = {res3}");
        }

        static void Pergunta3()
        {
            int x = 5, y = 1, z = 8, resultado = 0;
            if (z > Math.Pow(x, y))
            {
                resultado += 2;
            }
            else
            {
                resultado += 1;
            }

            for (int i = x; i > 1; i--)
            {
                resultado += 1;
            }

            while (y > 0)
            {
                resultado += 1;
                y--;
            }
            Console.WriteLine(resultado);
        }
    

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Pergunta1(); //contador
            //Pergunta2();
            Pergunta3();
        }
    }
}
