using System;
using System.ComponentModel.DataAnnotations;

namespace AppMvc.Models
{
    public class Product : Entity
    {
        public Supplier Supplier { get; set; }
        public Guid SupplierId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, ErrorMessage = "O campo {0} deve ter entre {1} e {2} caracteres", MinimumLength = 2 )]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo {0} deve ter entre {1} e {2} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, ErrorMessage = "O campo {0} deve ter entre {1} e {2} caracteres", MinimumLength = 2)]
        public string Image { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Valor { get; set; }
        
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Ativo { get; set; }

        

    }
}
