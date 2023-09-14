using System.ComponentModel.DataAnnotations;

namespace Entidades.Models
{
    public class Usuario
    {
        [Key]
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}
