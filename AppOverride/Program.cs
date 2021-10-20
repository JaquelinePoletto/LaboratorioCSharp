using System;

namespace AppOverride
{
    class SuperMostra
    {
        public string str = "Super String";

        public virtual void mostra()
        {
            Console.WriteLine("Super mostra! - str: {0}", str);
        }
    }
    class EstendeMostra : SuperMostra
    {
        public new string str = "Estende String";

        public override void mostra()
        {
            Console.WriteLine("---");
            base.mostra();
            Console.WriteLine("Estende mostra! - str: {0}", str);
            Console.WriteLine("---");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EstendeMostra e = new EstendeMostra();
            Console.WriteLine("str: {0}", e.str);
            e.mostra();
            
        }
    }

}

