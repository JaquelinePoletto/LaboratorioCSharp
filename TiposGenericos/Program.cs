using System;
// Programação Modular - Eixo 2 - UNIDADE 2 - Tema 2 - Tipos genéricos
// https://pucminas.instructure.com/courses/68911/pages/unidade-2-tema-2-tipos-genericos?module_item_id=1518848

namespace TiposGenericos
{
    public class Conjuntos  <T>
    {
        public static bool disjuntos ( T[] s, T[] w)
        {
            for(int i = 0; i < s.Length; i++)
            {
                for(int j=0; j < w.Length; j++)
                {
                    if (s[i].Equals(w[j]))
                        return false;
                }
            }
            return true;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo com int
            if (Conjuntos<int>.disjuntos(new int[] { 1, 3, 5 }, new int[] { 2, 4, 6, 1 }))
                Console.WriteLine("Conjuntos são disjuntos");
            else
                Console.WriteLine("Conjuntos NÂO são disjuntos");

            // Exemplo com double
            if (Conjuntos<double>.disjuntos(new double[] { 1.88, 3.14, 5 }, new double[] { 2.12, 4.5, 6.7, 1 }))
                Console.WriteLine("Conjuntos são disjuntos");
            else
                Console.WriteLine("Conjuntos NÂO são disjuntos");


        }
    }
}
