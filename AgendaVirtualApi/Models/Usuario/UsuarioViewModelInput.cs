using System.ComponentModel.DataAnnotations;

namespace AgendaVirtualApi.Models.Usuario
{
    public class UsuarioViewModelInput
    {
        [Required(ErrorMessage = "o campo login e obrigatorio.")]
        public string Login { get; set; }
        [Required(ErrorMessage = "o campo senha e obrigatorio.")]
        public string Senha { get; set; }   
    }
}