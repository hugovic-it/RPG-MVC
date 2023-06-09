using RPG_MVC.Context;
using System.Text.Json.Serialization;

namespace RPG_MVC.Models
{
    public class Jogador
    {
        //private readonly AppDbContext contexto = new AppDbContext { };

        public int JogadorId { get; set; }
        public string? Nome { get; set; }
        public int HpMax { get; set; }
        public int Hp { get; set; }
        public int MpMax { get; set; }
        public int Mp { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int Experiencia { get; set; }
        public int Moedas { get; set; }
        //public int? EquipamentoArmaId { get; set; }
        //[JsonIgnore]
        //public EquipamentoArma? EquipamentoArma { get; set; }
        //public int? EquipamentoArmaduraId { get; set; }
        //[JsonIgnore]
        //public EquipamentoArmadura? EquipamentoArmadura { get; set; }
        //[JsonIgnore]
        //public ICollection<Item>? Itens { get; set; }

        public override string ToString()
        {
            return $"JogadorId:{JogadorId} Nome:{Nome} HP:{HpMax}/{Hp} Mp:{MpMax}/{Mp} Forca:{Forca} Defesa:{Defesa} Experiencia:{Experiencia} Moedas:{Moedas}";
            //if (EquipamentoArmaId is null || EquipamentoArmaId is 0)
            //{
            //    return $"Id:{JogadorId} Nome:{Nome} HpMax:{HpMax} MpMax:{MpMax} Forca:{Forca} Defesa:{Defesa} Experiencia:{Experiencia} Moedas:{Moedas}";
            //}

            //var resultado = contexto.Armas.SingleOrDefault(x => x.EquipamentoArmaId == EquipamentoArmaId);
            //EquipamentoArma = resultado;  //garantindo que o objeto seja instanciando na memoria????
            //return $"Id:{JogadorId} Nome:{Nome} HpMax:{HpMax} MpMax:{MpMax} Forca:{Forca} Defesa:{Defesa} Experiencia:{Experiencia} Moedas:{Moedas}"
            //+ $"\n Arma Equipada: ID:{EquipamentoArma.EquipamentoArmaId} Nome:{EquipamentoArma.Nome} Ataque{EquipamentoArma.Ataque} Descricao: {EquipamentoArma.Descricao} "
            //+ $"\n Status atual: Hp:{HpMax}/{Hp} Mp:{MpMax}/{Mp}";

        }
    }
}
