using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace app_web_backend.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {       
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Obrigatório informar o nome!")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Obrigatório informar a placa")]
        public string Placa { get; set; }

        // chamado de relacionamento virtual porque no banco de dados nada será criado referente a este relacionamento
        public ICollection<Consumo> Consumos { get; set; }

    }
}
