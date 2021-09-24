using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaVirtualApi.Business.Entities
{
    public class Usuario
    {
        [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioID { get; set; }
        [Required]
        [StringLength(8)]
        public string Login { get; set; }
       [Required] 
       [StringLength(6)]
        public string Senha { get; set; }   
    }
}