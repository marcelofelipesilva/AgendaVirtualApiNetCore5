using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaVirtualApi.Business.Entities
{
    public class Contato
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContatoID { get; set; }
        [StringLength(50)] //nvarchar(50)
        public string Nome { get; set; }
        [StringLength(50)] //nvarchar(50)
        public string Email { get; set; }
        [StringLength(30)]
        public string Telefone { get; set; }
    }
}