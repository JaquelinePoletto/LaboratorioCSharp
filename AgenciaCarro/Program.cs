/* UNIDADE 2 - Tema 1 - Atributos, Propriedades e Métodos de Classe
 * Link: https://pucminas.instructure.com/courses/49011/pages/unidade-2-tema-1-atributos-propriedades-e-metodos-de-classe?module_item_id=1278821
 * Faça um programa que defina de forma completa uma classe de nome “Veículo” com os atributos 
 * “Nome”, “Marca”, “Ano de Fabricação” e “Placa”. 
 * Crie métodos capazes de ler os dados de um veículo e mostrar uma listagem de todos os veículos.
 * Cadastre em um vetor 30 veículos.
 */

using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaCarro
{
    class Veículo
    {
        private string _Nome;

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private string _Marca;

        public string Marca
        {
            get { return _Marca; }
            set { _Marca = value; }
        }

        private string _AnoFab;

        public string AnoFab
        {
            get { return _AnoFab; }
            set { _AnoFab = value; }
        }

        private string _Placa;

        public string Placa
        {
            get { return _Placa; }
            set { _Placa = value; }
        }

        // Métodos

        public void LêDados()
        {
            Console.Clear();

            Console.Write("Nome do Veículo..: ");
            _Nome = Console.ReadLine();

            Console.Write("Marca............: ");
            _Marca = Console.ReadLine();

            Console.Write("Ano de Fabricação: ");
            _AnoFab = Console.ReadLine();

            Console.Write("Placa............: ");
            _Placa = Console.ReadLine();
        }

        public void ListaDados()
        {
            Console.WriteLine($"\n{_Marca} {_Nome}");
            Console.WriteLine($"Placa {_Placa} - Ano {_AnoFab}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Classe Veículo
            // Atributos “Nome”, “Marca”, “Ano de Fabricação” e “Placa"
            // Métodos para Ler os dados de um veículo e Listar todos os veículos 
            // Total de 30 veículos;

            Veículo[] CadVeículo = new Veículo[3];

            for (int i = 0; i < 3; i++)
            {
                Veículo x = new Veículo();      // Instância do Objeto

                // x é um objeto e sabe ler os dados de um veículo...
                x.LêDados();

                // Nesse momento x já possui todos os dados lidos
                // Vamos armazenar no vetor...
                CadVeículo[i] = x;
            }

            Console.Clear();

            foreach (Veículo V in CadVeículo)
            {
                // Para cada veículo V no cadastro...
                V.ListaDados();
            }

            Console.ReadKey();
        }
    }
}

