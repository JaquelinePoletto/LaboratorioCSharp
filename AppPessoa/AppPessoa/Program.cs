/* Eixo 2 - Programação modular */
/* https://pucminas.instructure.com/courses/68911/pages/unidade-1-tema-2-atributos-e-metodos?module_item_id=1484280 */

using System;

namespace AppPessoa
{
    class Pessoa
    {
        private string _NomePessoa;
        private string _Endereco;
        private string _Telefone;

        public string NomePessoa { get { return _NomePessoa; } set { _NomePessoa = value; } }
        public string Endereco { get { return _Endereco; } set { _Endereco = value; } }
        public string Telefone { get { return _Telefone; } set { _Telefone = value; } }

        public Pessoa(string nome, string ender, string fone)
        {
            _NomePessoa = nome;
            _Endereco = ender;
            _Telefone = fone;
        }

        public Pessoa()
        {
            _NomePessoa = "";
            _Endereco = "";
            _Telefone = "";
        }

        public string PrimeiroNome()
        {
            int j = _NomePessoa.IndexOf(" ");
            
            //Console.WriteLine($"j = {j}");
            
            return (_NomePessoa.Substring(0, j));
        }

    }

    class PessoaFisica : Pessoa
    {
        private string _CPF;

        public string CPF { get => _CPF; set => _CPF = value; }

        public PessoaFisica(string cpf)
        {
            _CPF = cpf;
        }
        public PessoaFisica()
        {
 
        }
    }

    class PessoaJuridica : Pessoa
    {
        private string _CNPJ;

        public string CNPJ { get => _CNPJ; set => _CNPJ = value; }

        public PessoaJuridica(string nome, string ender, string fone, string cnpj) : base(nome, ender, fone)
        {
            _CNPJ = cnpj;
        }
        public PessoaJuridica()
        {

        }
    }

    class Program
    {
        static void UsaConstrutorPadrao()
        {
            Pessoa p = new Pessoa();
            p.NomePessoa = "Jaqueline Poletto";
            Console.WriteLine($"Nome Completo: { p.NomePessoa}");
            Console.WriteLine($"Primeiro Nome: { p.PrimeiroNome()}");
        }

        static void UsaConstrutorParam()
        {
            Console.Write("Qual é o seu nome completo: ");
            string nome = Console.ReadLine();
            Console.Write("Qual é o seu endereço: ");
            string ender = Console.ReadLine();
            Console.Write("Qual é o seu telefone: ");
            string fone = Console.ReadLine();
            Pessoa p2 = new Pessoa(nome, ender, fone);
            Console.WriteLine($"Nome Completo: { p2.NomePessoa}");
            Console.WriteLine($"Primeiro Nome: { p2.PrimeiroNome()}");
            Console.WriteLine($"Endereço: { p2.Endereco}");
            Console.WriteLine($"Telefone: { p2.Telefone}");
        }
        
        // Herança: https://pucminas.instructure.com/courses/68911/pages/unidade-1-tema-4-generalizacao-e-especificacao?module_item_id=1518867
        static void UsaHeranca()
        {
            string nome = "Edson Torres";
            string ender = "Rua das montanhas, 385";
            string fone = "2345-9087";
            string cpf = "0689875911";

            PessoaFisica p = new PessoaFisica();
            p.NomePessoa = nome;
            p.Telefone = fone;
            p.Endereco = ender;
            p.CPF = cpf;
            Console.WriteLine($"Primeiro Nome: { p.PrimeiroNome()}");
            Console.WriteLine($"CPF: { p.CPF}");
        }

        // Construtor classe filha: https://pucminas.instructure.com/courses/68911/pages/unidade-1-tema-4-construtores-em-classes-filhas?module_item_id=1484281
        static void UsaConstrutorClasseFilha()
        {
            string nome = "Maderuai";
            string ender = "Rua das montanhas, 385";
            string fone = "2345-9087";
            string cnpj = "89875911000150";

            PessoaJuridica p = new PessoaJuridica();
            p.NomePessoa = nome;
            p.Telefone = fone;
            p.Endereco = ender;
            p.CNPJ = cnpj;
            Console.WriteLine($"Empresa: { p.NomePessoa}");
            Console.WriteLine($"Telefone: { p.Telefone}");
            Console.WriteLine($"Endereco: { p.Endereco}");
            Console.WriteLine($"CNPJ: { p.CNPJ}");
        }
        static void Main(string[] args)
        {
            //UsaConstrutorPadrao();

            //UsaConstrutorParam();

            //UsaHeranca();

            UsaConstrutorClasseFilha();
        }
    }
}
