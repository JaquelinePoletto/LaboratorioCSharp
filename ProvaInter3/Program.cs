using System;

namespace ProvaInter3
{
    class Program
    {
        static void pergunta2()
        {
            int num = 0, cont1 = 0, cont2 = 0;
            // entrada 1 1 1 -1 -1 -1 0 cont1=3, cont2 = 4
            // entrada 1 1 1 -1 -1 0 cont1=3   cont2 =3 
            // entrada 1 -1 1 -1 1 0 cont1=3   cont2 =3 

            do
            {
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    cont1++;
                }
                else {
                    cont2++;
                }
            } while (num != 0);
            
            Console.WriteLine($"Cont1 = {cont1}, Cont2 = {cont2}");
            
        }

        static void pergunta12()
        {
            // O comando Z será executado sempre que C for falso. - 
            //Conclusão: FALSO
            //bool A = true, B = true, C = false; // falso - executou o X           

            //O comando X será executado sempre que A for falso.: 
            // conclusão: FALSO
            //bool A = false, B = true, C = true; // falso - executou o Z            

            //O comando Z será executado sempre que A for falso.
            //Conclusão: VERDADEIRO
            //bool A = false, B = true, C = true; //verdade - executou o z
            //bool A = false, B = false, C = true; //verdade - executou o z
            //bool A = false, B = false, C = false; //verdade - executou o z
            //bool A = false, B = true, C = false; //verdade - executou o z

            // O comando Y será executado sempre que A for falso.
            // conclusão: FALSO
            //bool A = false, B = true, C = true; // falso // executou o z

            // O comando Y será executado sempre que C for verdadeiro.
            //Conclusão: FALSO
            bool A = false, B = false, C = true; // falso // executou o z            

            if (A && B)

                Console.WriteLine("comando X");

            else if (A && C)
            
                Console.WriteLine("comando Y");

            else

                Console.WriteLine("comando Z");
        }

        static void pergunta14()
        {
            //O comando Y será executado sempre que A e B foram falsos.
            //Conclusão: VERDADEIRO
            //bool A = false, B = false, C = true; // verdade - executou o Y           
            //bool A = false, B = false, C = false; // verdade - executou o Y

            // O comando Y será executado sempre que A for falso.
            // Conclusão: falso
            bool A = false, B = true, C = false; // falso - executou o x

            if (A || B)

                Console.WriteLine("comando X");

            else if (!(A && C))

                Console.WriteLine("comando Y");

            else

                Console.WriteLine("comando Z");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            pergunta2();

            //pergunta12();

            //pergunta14();
        }
    }
}
