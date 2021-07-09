using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppMvc.Models
{
    public class Supplier : Entity
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, ErrorMessage = "O campo {0} deve ter entre {1} e {2} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} deve ter entre {1} e {2} caracteres", MinimumLength = 11)]
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Address Endereco { get; set; }
        public bool Ativo { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }

    public enum TipoFornecedor 
    { 
        PessoaFisica = 1,
        PessoaJuridica = 2
    }

}
