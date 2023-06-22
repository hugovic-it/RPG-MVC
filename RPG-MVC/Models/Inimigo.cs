using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace RPG_MVC.Models
{
    [Table("Inimigos")]
    public class Inimigo
    {
        [Key]
        [NotNull]
        public int InimigoId { get; set; }
        [StringLength(80, ErrorMessage = "O campo não pode possuir mais que 80 caracteres")]
        [Required(ErrorMessage = "O campo Nome não pode ser nulo.")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "O campo HpMax não pode ser nulo.")]
        public int HpMax { get; set; }
        public int Hp { get; set; }
        [Required(ErrorMessage = "O campo MpMax não pode ser nulo.")]
        public int MpMax { get; set; }
        public int Mp { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int Experiencia { get; set; }
        public int Moedas { get; set; }
        public string? Imagem { get; set; }

        public override string ToString()
        {
            return
            $"Id:{InimigoId} Nome:{Nome} HpMax:{HpMax} MpMax:{MpMax} Forca:{Forca} Defesa:{Defesa} Experiencia:{Experiencia} Moedas:{Moedas}";
        }
    }
}
