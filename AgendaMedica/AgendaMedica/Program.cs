/* UNIDADE 2 - Tema 1 - Definição de um TAD - Classes e Objetos
 * Link: https://pucminas.instructure.com/courses/49011/pages/unidade-2-tema-1-definicao-de-um-tad-classes-e-objetos?module_item_id=1278820
 * Faça um programa que possa ser usado por uma clínica para cadastrar: 30 pacientes, 
 * a data da consulta, a hora de sua realização, o nome de um paciente e o nome do médico que o atenderá. 
 * Depois de os dados serem informados, o programa deve conter uma opção que, o usuário fornecendo o nome do médico, 
 * liste toda a agenda dele. 
 * Considere que o atributo Data da consulta” seja também estruturado, formado pelos campos Dia, Mês e Ano.
 */
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaMedica
{
    class Paciente
    {                                
        private string _NomePaciente;
        private string _NomeMédico;
        private Data _DataConsulta;
        private string _HoraConsulta;

        public string NomePaciente {get {return _NomePaciente;} set {_NomePaciente = value;}}       
        public string NomeMédico   {get {return _NomeMédico;  } set {_NomeMédico = value;  }}        
        public Data DataConsulta   {get {return _DataConsulta;} set {_DataConsulta = value;}}
        public string HoraConsulta {get {return _HoraConsulta;} set {_HoraConsulta = value;}}
    }

    class Data
    {
        public string Dia;
        public string Mês;
        public string Ano;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Cadastro de 30 Pacientes
            // Informações sobre Data e Hora da Consulta, Paciente e Médico
            // Listagem de toda a agenda do médico segundo seu nome

            Paciente[] Cadastro = new Paciente[3];      // Vetor com 3 posições para teste...

            for (int i = 0; i < 3; i++)
            {
                Paciente x = new Paciente();            // Objeto - Instância

                Console.Write($"\nNome do Paciente nr. {i + 1}: ");
                x.NomePaciente = Console.ReadLine();

                Console.Write("Médico................: ");
                x.NomeMédico = Console.ReadLine();

                x.DataConsulta = new Data();        // Muito importante... Instância

                Console.Write("Data da Consulta - Dia: ");
                x.DataConsulta.Dia = Console.ReadLine();

                Console.Write("                   Mês: ");
                x.DataConsulta.Mês = Console.ReadLine();

                Console.Write("                   Ano: ");
                x.DataConsulta.Ano = Console.ReadLine();

                Console.Write("Hora da Consulta......: ");
                x.HoraConsulta = Console.ReadLine();

                Cadastro[i] = x;                    // Cadastro feito.
            }

            Console.Clear();

            string NomeMédico;

            Console.Write("Digite o Nome de um Médico: ");
            NomeMédico = Console.ReadLine();

            foreach (Paciente P in Cadastro)
            {
                if (P.NomeMédico == NomeMédico)
                {
                    Console.WriteLine($"\nPaciente: {P.NomePaciente}");
                    Console.WriteLine($"{P.DataConsulta.Dia}/" +
                                      $"{P.DataConsulta.Mês}/" +
                                      $"{P.DataConsulta.Ano} - " +
                                      $"{P.HoraConsulta} Horas");
                }
            }

            Console.ReadKey();
        }
    }
}
