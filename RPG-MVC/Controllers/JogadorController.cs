using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RPG_MVC.Context;
using RPG_MVC.Models;

namespace RPG_MVC.Controllers
{
    public class JogadorController : Controller
    {
        private readonly AppDbContext _context;

        public JogadorController(AppDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CadastrarJogador()
        {
            return View();
        }

        public ActionResult PersistirJogador(Jogador jogador)
        {
            try
            {
                jogador.Hp = jogador.HpMax;
                jogador.Mp = jogador.MpMax;
                jogador.Experiencia = 0;
                jogador.Moedas = 0;
                _context.Add(jogador);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Ocorreu um erro: " + e.Message);
            }



            return View(jogador);
        }
        public ActionResult VerJogador()
        {
            Jogador jogador = null;
            try{
                jogador = _context.Jogadores.FirstOrDefault(x => x.JogadorId == 1);
            }catch (Exception e) {}
            if (jogador is null){
                return View();
                //return RedirectToAction("Index");
            }
            else {
                return View(jogador);
            }
        }
        public ActionResult VerTodosJogadores()
        {
            //System.Console.WriteLine("Informações dos jogadores: ");
            List<Jogador> jogadores;
            try { 
                jogadores = _context.Jogadores.ToList();
            }catch (Exception e)
            {
                //System.Console.WriteLine(e.Message);
                return View("Index");
            }
            
            //foreach (Jogador jogador in jogadores){System.Console.WriteLine(jogador.ToString());}

            return View(jogadores);
        }



    }
}
