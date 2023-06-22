using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RPG_MVC.Models
{
    [Table("Armas")]
    public class Arma
    {
        [Key]
        public int ArmaId { get; set; }
        [StringLength(80)]
        public string? Nome { get; set; }
        [StringLength(300)]
        public string? Descricao { get; set; }
        [Required(ErrorMessage = "O campo Ataque não pode ser nulo.")]
        public int Ataque { get; set; }
        public string? Imagem { get; set; }

        public override string ToString()
        {
            return $"Id: {ArmaId}\nNome: {Nome}\nDescricao: {Descricao}\nAtaque: {Ataque}";
        }
    }
}
