using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_web_backend.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Descrição")]
        [Required(ErrorMessage ="*Campo Obrigatório")] 
        public string Descricao { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório")]
        public int Km { get; set; }

        [Column(TypeName="decimal(18,2)")]
        [Required(ErrorMessage = "*Campo Obrigatório")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatório")]
        [Display(Name = "Tipo de Combustível")]
        public TipoCombustivel Tipo { get; set; }

        /* Criando a chave estrangeira para veículo */
        [Display(Name ="Veículo")]
        [Required(ErrorMessage = "*Campo Obrigatório")]
        public int VeiculoId { get; set; }
        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }

    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol
    }
}
