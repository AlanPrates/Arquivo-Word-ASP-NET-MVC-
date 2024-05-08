using System.ComponentModel.DataAnnotations;

namespace WordPrates.Models
{
    public class Documento
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]

        public string Titulo { get; set; } = string.Empty;
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]

        public string Conteudo { get; set; } = string.Empty;

        public DateTime DataCriacao { get; set; } = DateTime.Now;

        public DateTime DataAlteracao { get; set; } = DateTime.Now;
    }
}
