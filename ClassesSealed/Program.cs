using System;

// UNIDADE 2 - Tema 1 - Classes e membros selados (sealed)
// https://pucminas.instructure.com/courses/68911/pages/unidade-2-tema-1-classes-e-membros-selados-sealed?module_item_id=1518873

namespace ClassesSealed
{
    class Extensivel
    {
        public virtual void Primeiro()
        {
            Console.WriteLine("Extensível: primeiro método");
        }
        public virtual void Segundo()
        {
            Console.WriteLine("Extensível: segundo método");
        }
    }

    class MembroSelado: Extensivel
    {
        public sealed override void Primeiro()
        {
            Console.WriteLine("Membro selado: primeiro método");
        }
        public override void Segundo()
        {
            Console.WriteLine("Membro não selado: segundo método");
        }
    }

    sealed class Selada: MembroSelado
    {
        // Tentativa de sobrepor um método selado
        // error CS0239: 'Selada.Primeiro()': cannot override inherited member 'MembroSelado.Primeiro()'
        /*protected override void Primeiro()
        {
            Console.WriteLine("selada: primeiro método");
        }*/

        public override void Segundo()
        {
            Console.WriteLine("selada: segundo método");
        }
    }

    // Tentativa de estender uma classe selada.
    // error CS0509: 'Sobreposicao': cannot derive from sealed type 'Selada'
    /*class Sobreposicao : Selada
    {

    }*/



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Parte do código não compila. Foi comentado.");
        }
    }
}
