using System.ComponentModel.DataAnnotations;

namespace AgendaVirtualApi.Models.Tarefa
{
    public class TarefaViewModelInput
    {
        [Required(ErrorMessage = "o campo nome e obrigatorio.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "o campo data de entrega e obrigatorio.")]
        public string dataEntrega { get; set; }
        [Required(ErrorMessage = "o campo descricao e obrigatorio.")]
        public string Descricao { get; set; }
    }
}