using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaVirtualApi.Business.Entities
{
    public class Tarefa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TarefaID { get; set; }
        [StringLength(50)]
        public string Nome { get; set; }
        [StringLength(35)]
        public string dataEntrega { get; set; }
        [StringLength(350)]
        public string Descricao { get; set; }
    }
}