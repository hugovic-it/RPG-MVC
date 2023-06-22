using Microsoft.AspNetCore.Mvc;
using RPG_MVC.Context;
using RPG_MVC.Interfaces;

namespace RPG_MVC.Services
{
    public class JogadorService : IJogadorService
    {
        private readonly AppDbContext contexto;
        public JogadorService(AppDbContext context)
        {
            contexto = context;
        }

        public void EquiparArma(int jogadorId, int armaId)
        {
            var jogador = contexto.Jogadores.FirstOrDefault(x => x.JogadorId == jogadorId);

            if (jogador is null)
            {
                //Jogador nulo
                return;
                //throw new Exception("jogador is null.");
            }
            var arma = contexto.Armas.FirstOrDefault(x => x.ArmaId == armaId);
            if (arma is null)
            {
                //Arma nula
                return;
                //throw new Exception("jogador is null.");
            }

            if (jogador.ArmaId is not null)
            {
                var armaEquipada = contexto.Armas.First(x => x.ArmaId == jogador.ArmaId);
                jogador.Forca = jogador.Forca - armaEquipada.Ataque; //removendo o status da arma que sera removida
            }

            jogador.ArmaId = arma.ArmaId;  //recebendo a nova arma
            jogador.Forca = jogador.Forca + arma.Ataque; //aplicando o status da nova arma
            jogador.ArmaId = armaId;

            //Chave-estrangeira problem?
            jogador.Arma = arma;

            //ao reiniciar a aplicação, o codigo persiste os status do jogador, mas não o da arma equipada
            contexto.Jogadores.Update(jogador);
            contexto.SaveChanges();

        }

        /*
        public void EquiparArmadura(int jogadorId, int armaduraId)
        {
            var jogador = contexto.Jogadores.FirstOrDefault(x => x.JogadorId == jogadorId);

            if (jogador is null)
            {
                System.Console.WriteLine("Jogador nulo");
                return;
            }
            var armadura = contexto.Armaduras.FirstOrDefault(x => x.EquipamentoArmaduraId == armaduraId);
            if (armadura is null)
            {
                System.Console.WriteLine("Armadura nula");
                return;
            }

            if (jogador.EquipamentoArmaduraId != 0)
            {
                var armaduraEquipada = contexto.Armaduras.First(x => x.EquipamentoArmaduraId == jogador.EquipamentoArmaduraId);
                jogador.Defesa = jogador.Defesa - armaduraEquipada.Defesa; //removendo o status da arma que sera removida
            }

            jogador.EquipamentoArmaduraId = armadura.EquipamentoArmaduraId;  //recebendo a nova arma
            jogador.Forca = jogador.Forca + armadura.Defesa; //aplicando o status da nova arma
            jogador.EquipamentoArmaId = armaduraId;

            //Chave-estrangeira problem?
            jogador.EquipamentoArmadura = armadura;

            //ao reiniciar a aplicação, o codigo persiste os status do jogador, mas não o da arma equipada
            contexto.Jogadores.Update(jogador);
            contexto.SaveChanges();
            System.Console.WriteLine("Armadura equipada com sucesso!");
        }
        */
    }
}
