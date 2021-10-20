using System;
using System.Drawing;

// https://pucminas.instructure.com/courses/68911/pages/unidade-2-tema-1-classes-abstratas?module_item_id=1518872
// Eixo 2 - Programação Modular - UNIDADE 2 - Tema 1 - Classes abstratas

namespace AppFiguraPolimorfismo
{
    public abstract class Figura
    {
        public int X { get; set; }
        public int Y { get; set; }     
        public Color Cor { get; set; }
        public bool Preenchido { get; set; }

        public Figura (int x, int y, Color cor, bool preenchido)
        {
            X = x;
            Y = y;            
            Cor = cor;
            Preenchido = preenchido;
        }
        // Método abstrato - não possui implementação
        public abstract void Desenhar();
        public abstract void CalculaArea();
        public abstract void CalculaPerimetro();

    }

    class Quadrado: Figura
    {
        public int Lado { get; set; }
        public Quadrado(int x, int y, Color cor, bool preenchido, int lado) : base(x, y, cor, preenchido)
        {
            Lado = lado;
        }

        public override void Desenhar()
        {
            Console.WriteLine($"Desenhando um quadrado na posição ({X}, {Y}) com tamanho {Lado} a cor {Cor}");
        }

        public override void CalculaArea()
        {
            Console.WriteLine("A área do quadrado é: {0} ", Lado * Lado);
        }

        public override void CalculaPerimetro()
        {
            Console.WriteLine("O Perímetro do quadrado é: {0} ", Lado * 4);
        }

    }

    class Circulo : Figura
    {
        public int Raio { get; set; }
        public Circulo(int x, int y, Color cor, bool preenchido, int raio): base(x, y, cor, preenchido)
        {           
            Raio = raio;            
        }

        public override void Desenhar()
        {           
            Console.WriteLine($"Desenhando um círculo na posição ({X}, {Y}) com raio {Raio} a cor {Cor}");
        }
        public override void CalculaArea()
        {
            Console.WriteLine("A área do círculo é: {0} ", Math.PI*(Raio * Raio));
        }
        public override void CalculaPerimetro()
        {
            Console.WriteLine("O Perímetro do círculo é: {0} ", 2*Math.PI*Raio);
        }

    }
    class Program
    {
        public static Figura[] figuras = new Figura[10];
        public static int NumFig = 0;
        static void FormaSimples()
        {
            Quadrado q = new Quadrado(5, 8, Color.Blue, true, 20);
            q.Desenhar();
            q.CalculaArea();
        }

        static void FormaLegal()
        {
            figuras[NumFig++] = new Quadrado(10, 20, Color.Red, true, 30);
            figuras[NumFig++] = new Circulo(30, 25, Color.Black, false, 15);
            figuras[NumFig++] = new Quadrado(50, 70, Color.Red, true, 33);

            for(int pos = 0; pos < NumFig; pos++)
            {
                Console.WriteLine(figuras[pos]);
                figuras[pos].Desenhar();
                figuras[pos].CalculaArea();
                figuras[pos].CalculaPerimetro();
            }
        }
        static void Main(string[] args)
        {
            //FormaSimples();

            // uma forma mais legal de utilizar a classe Figura 
            FormaLegal();
        }
    }

}
