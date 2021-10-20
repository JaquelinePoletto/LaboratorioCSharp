using System;
/*
 * https://pucminas.instructure.com/courses/68911/pages/unidade-1-tema-3-metodos-de-acesso-e-propriedades?module_item_id=1518861
1. Crie uma classe Conta, que representa uma conta bancária com um atributo saldo do tipo float e um atributo criacao do tipo DateTime. 

Em seguida, implemente um atributo chamado numero, que representa o número da conta bancária, e deve ser um número sequencial, gerado automaticamente, a cada vez que uma instância de Conta é criada.

Utilize modificadores de acesso para encapsular todos os atributos de Conta.

Utilize propriedades somente-leitura para acessar o valor do saldo, data de criação e número da conta.

Crie os métodos  para sacar e depositar quantias na conta corrente, conforme as assinaturas: 

public float Sacar(float value) 

public float Depositar(float value) 
 */



namespace AppContaBancaria
{
    class ContaBancaria
    {
        private int _CodBanco;
        private string _CodAgencia;
        private int _NroConta;
        private float _SaldoConta = 0;
        private DateTime _dtCriacao;

        public static int Contador;

        public int CodBanco { get => _CodBanco; set => _CodBanco = value; }
        public string CodAgencia { get => _CodAgencia; set => _CodAgencia = value; }
        public int NroConta { get => _NroConta; }
        public float SaldoConta { get => _SaldoConta; }
        public DateTime DtCriacao { get => _dtCriacao; set => _dtCriacao = value; }

        public ContaBancaria(float saldoinicial, DateTime criacao)
        {
            _SaldoConta = saldoinicial;
            DtCriacao = criacao;
        }
        public ContaBancaria(int codbanco, string codagencia)
        {
            this._CodBanco = codbanco;
            this._CodAgencia = codagencia;
            this._NroConta = ++ContaBancaria.Contador;
            this._SaldoConta = 100;
        }
        public float Sacar(float quantia)
        {
            if (_SaldoConta < quantia)
                throw new ArgumentException("Quantia de saque não permitida", "quantia");
            _SaldoConta = this._SaldoConta - quantia;
            return quantia;
        }

        public float Depositar(float quantia)
        {
            if (quantia > 0)
            {
                this._SaldoConta = this._SaldoConta + quantia;
                return (this._SaldoConta);
            }
            else
            {
                Console.WriteLine("Valor do depósito de {0} é invalido", quantia);
                return (-1);
            }
                
        }

    }
    public class MainClass //Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c1 = new ContaBancaria(335, "0886-7");
            Console.WriteLine("Banco: {0} - Agencia: {1} - Conta: {2} - Saldo Inicial: {3}", c1.CodBanco, c1.CodAgencia, c1.NroConta, c1.SaldoConta);

            ContaBancaria c2 = new ContaBancaria(281, "1453-0");
            Console.WriteLine("Banco: {0} - Agencia: {1} - Conta: {2} - Saldo Inicial: {3}", c2.CodBanco, c2.CodAgencia, c2.NroConta, c2.SaldoConta);

            float val = -500;
            c1.Depositar(val);           
            Console.WriteLine("Saldo após depósito de {0} na 1a. conta: {1}", val, c1.SaldoConta);            

            val = 30;
            c2.Sacar(val);
            Console.WriteLine("Saldo após saque de {0} na 2a. conta: {1}", val, c2.SaldoConta);

        }
    }
}
