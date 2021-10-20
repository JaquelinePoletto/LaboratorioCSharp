/* Eixo 2 - Programação modular
 * EXEMPLO DE CONTADOR AUTOINCREMENTO 
 * https://pucminas.instructure.com/courses/68911/pages/unidade-1-tema-2-atributos-estaticos-e-propriedades?module_item_id=1518854 */

using System;

namespace AppProduto
{
    class Produto
    {
        private int id;
        private string descricao;
        private float preco;
        private int quantidade;
        private DateTime fabricacao;

        public static int contador;

        // Publicando as propriedades Descricao e Preço: https://pucminas.instructure.com/courses/68911/pages/unidade-1-tema-3-metodos-de-acesso-e-propriedades?module_item_id=1518861
        public string Descricao
        {
            get => this.descricao;
            set { if (value.Length >= 3) this.descricao = value; }
        }

        public float Preco
        {
            get => preco;
            set { if (value > 0) this.preco = value; }
        }

        // publicando a Quantidade sem o set
        public int Quantidade
        {
            get => quantidade;            
        }
        
        public DateTime Fabricacao { get => fabricacao; set => fabricacao = value; }

        public Produto(String descricao, float preco, int quantidade, DateTime fabricacao)
        {
            this.id = ++Produto.contador;

            if (descricao.Length >= 3)
                this.descricao = descricao;
            if (preco > 0)
                this.preco = preco;
            if (quantidade >= 0)
                this.quantidade = quantidade;
            this.fabricacao = fabricacao;
        }

        public Produto()
        {
            this.id = ++Produto.contador;
            this.descricao = "Novo Produto";
            this.preco = 0.01F;
            this.quantidade = 0;
        }

        public bool emEstoque()
        {
            return (quantidade > 0);
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"Produto {id}: {descricao}   Preço: {preco:C2}   Quant.: {quantidade}  Fabricação:  {fabricacao}";
            // C2 - coloca no formato de dinheiro. Muito legal.
        }
    }

    // Classe Bem de Consumo:
    class BemDeConsumo : Produto
    {
        private DateTime validade;

        public DateTime Validade
        {
            get => this.validade;
            set => this.validade = (value > DateTime.Now) ? value : DateTime.Now;
        }

        public BemDeConsumo(string descricao, float preco, int quantidade, DateTime fabricacao, DateTime validade) : base(descricao, preco, quantidade, fabricacao)
        {
            this.validade = validade;
        }

        public override string ToString()
        {
            // é assim que se faz o inherited no c#
            return base.ToString() + $"   Validade:  {validade}";
        }
    }

    class BemDuravel : Produto
    {
        private int garantia;
        public int Garantia
        {
            get => this.garantia;
            set => this.garantia = (value > 0) ? value : 6;
        }

        public BemDuravel(string descricao, float preco, int quantidade, DateTime fabricacao, int garantia) : base(descricao, preco, quantidade, fabricacao)
        {
            this.Garantia = garantia;
        }

        public override string ToString()
        {
            return base.ToString() + $"  Garantia:  {garantia}";
        }
    }
    class Program
    {
        static void UsaAtributoStatic()
        {
            Console.WriteLine("1o. Contador de produtos: {0}", Produto.contador);
            Produto p = new Produto("Latão", 2.99F, 50, DateTime.Today);
            Console.WriteLine("2o. Contador de produtos: {0}", Produto.contador);
            Produto p2 = new Produto("Vinho", 18, 32, DateTime.Today);
            Console.WriteLine("3o. Contador de produtos: {0}", Produto.contador);
        }
        static void Main(string[] args)
        {
            //UsaAtributoStatic();         
            Produto p = new Produto("Macarrao", 3, 22, DateTime.Today);
            Console.WriteLine("O preço do {0} é : {1}", p.Descricao, p.Preco);
            Console.WriteLine("A quantidade é : {0}", p.Quantidade);
            p.Descricao = "Macarrao Fidelinho";
            Console.WriteLine("Descrição alterada: {0} ", p.Descricao);
            // p.Quantidade não pode ser alterado porque não declarei o set.

            Console.WriteLine("usando override: {0}", p.ToString());

            BemDeConsumo c = new BemDeConsumo("Feijão", 8, 20, DateTime.Today, DateTime.Today.AddDays(30));
            Console.WriteLine("usando override 2: {0}", c.ToString());

            Console.WriteLine("Bem de consumo:");
            Console.WriteLine(c);

            BemDuravel bemDuravel = new BemDuravel("Notebook", 4200, 10, DateTime.Now.AddDays(-90), 12);

            Console.WriteLine("Bem Duravel:");
            Console.WriteLine(bemDuravel);
        }
    }
}
