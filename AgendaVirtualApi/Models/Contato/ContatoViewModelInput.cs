using System.ComponentModel.DataAnnotations;

namespace AgendaVirtualApi.Models.Contato
{
    public class ContatoViewModelInput
    {
        [Required(ErrorMessage = "o campo nome e obrigatorio.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "o campo email e obrigatorio.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "o campo telefone e obrigatorio.")]
        public string Telefone { get; set; }
    }
}