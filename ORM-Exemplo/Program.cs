// UNIDADE 1 - Tema 2 - Frameworks Web
// https://pucminas.instructure.com/courses/68749/pages/unidade-1-tema-2-frameworks-web?module_item_id=1484294

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ORM_Exemplo
{
    public class Genero
    {
        [Key] // informa que o campo Id é chave e é auto-incremento
        public int Id { get; set; }
        public string Descricao { get; set; }
        public ICollection<Filme> Filme { get; set; }
    }

    public class Filme
    {
        [Key] 
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int GeneroId { get; set; }
        [ForeignKey("GeneroId")]
        public Genero Genero { get; set; }

    }

    public class ApplicationContext: DbContext
    {
        public DbSet <Genero> Genero { get; set; }
        public DbSet <Filme> Filme { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQL2019EXPRESS;Database=ORM;Trusted_Connection=True");
        }

    }

    /* Após criar as classes Genero, Filme e ApplicationContext, ir no menu Ferramentas e executar 
     * "Gerenciador de pacotes do NuGet/Console do Gerenciador de Pacotes"
     * Será aberta a linha de comandos PM>
     * Digite:
     * PM> add-migration ormdb
     * Será criada uma pastinha no projeto chamada migrations e nela serão colocados os códigos que serão utilizados para criar o banco de dados.
     * Para criar o banco de dados de fato, voltar ao console e excutar:
     * PM> update-database
     * O banco de dados será criado no sqlserver.
     * */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var context = new ApplicationContext())
            {
                var genero = new Genero()
                {
                    Descricao = "Fantasia"
                };
                context.Genero.Add(genero);
                context.SaveChanges();

                var filme = new Filme()
                {
                    Titulo = "De volta para o Futuro",
                    GeneroId = genero.Id
                };
                context.Filme.Add(filme);
                context.SaveChanges();
            }
        }
    }
}
