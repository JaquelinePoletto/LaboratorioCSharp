/* UNIDADE 2 - Tema 1 - Mecanismos de Visibilidade/Acessibilidade
 * Link: https://pucminas.instructure.com/courses/49011/pages/unidade-2-tema-1-mecanismos-de-visibilidade-slash-acessibilidade?module_item_id=1278822
 * Um Número Complexo possui a forma “a+bi”, sendo “a” a Parte Real do número e “b” a parte imaginária. 
 * O caractere “i” se refere à raiz quadrada de -1 (−1−−−√ ). 
 * Pesquise a forma como são feitas as operações de Soma, Subtração, Multiplicação e Divisão de números complexos. 
 * Crie uma classe de nome “Complex” e implemente a solução para esse problema. 
 * Crie os atributos PReal e PImag (as duas partes do número complexo) e os métodos solicitados. 
 * Preste bastante atenção à visibilidade de atributos e métodos.
 */

using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosComplexos
{
    class Complex
    {
        private double PReal;
        private double PImag;

        public void LerComplex()
        {
            Console.Write("\nParte Real......: ");
            PReal = double.Parse(Console.ReadLine());

            Console.Write("Parte Imaginária: ");
            PImag = double.Parse(Console.ReadLine());
        }

        public void MostraComplex(string Título)
        {
            Console.Write($"\n{Título}");

            Console.WriteLine($"{PReal:F2}{(PImag >= 0 ? " + " : " - ")}{Math.Abs(PImag):F2}i");

            Console.ReadKey();
        }

        public void SomaComplex(Complex a, Complex b)
        {
            PReal = a.PReal + b.PReal;
            PImag = a.PImag + b.PImag;
        }

        public void SubtraiComplex(Complex a, Complex b)
        {
            PReal = a.PReal - b.PReal;
            PImag = a.PImag - b.PImag;
        }

        public void MultiplicaComplex(Complex a, Complex b)
        {
            PReal = a.PReal * b.PReal - a.PImag * b.PImag;
            PImag = a.PReal * b.PImag + a.PImag * b.PReal;
        }

        public void DivideComplex(Complex a, Complex b)
        {
            Complex Aux = new Complex();

            b.AchaConjugado();

            Aux.MultiplicaComplex(a, b);

            PReal = Aux.PReal / (Math.Pow(b.PReal, 2) + Math.Pow(b.PImag, 2));
            PImag = Aux.PImag / (Math.Pow(b.PReal, 2) + Math.Pow(b.PImag, 2));
        }

        private void AchaConjugado()        // Isso pode ser private...
        {
            PImag = -PImag;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex();
            Complex b = new Complex();

            Complex Soma = new Complex();
            Complex Subtração = new Complex();
            Complex Multiplicação = new Complex();
            Complex Divisão = new Complex();

            a.LerComplex();
            b.LerComplex();

            Soma.SomaComplex(a, b);
            Subtração.SubtraiComplex(a, b);
            Multiplicação.MultiplicaComplex(a, b);
            Divisão.DivideComplex(a, b);

            Console.WriteLine("\n");

            Soma.MostraComplex("Soma: ");
            Subtração.MostraComplex("Subtração: ");
            Multiplicação.MostraComplex("Multiplicação: ");
            Divisão.MostraComplex("Divisão: ");
        }
    }
}

