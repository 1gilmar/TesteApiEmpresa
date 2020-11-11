using System;
using System.ComponentModel.DataAnnotations;

namespace TApi.Models
{
    public class Patrimonio
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string Nome { get; set; }

        [MaxLength(1024, ErrorMessage = "Este campo deve conter no máximo 1024 caracteres")]
        public string Descicao { get; set; }

        public decimal NdoTombo { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Marca inválida")]
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }
    }
}
