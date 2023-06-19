using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RPG_MVC.Context;
using RPG_MVC.Models;


namespace RPG_MVC.Controllers
{
    public class InimigoController : Controller
    {

        private readonly AppDbContext _context;

        public InimigoController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult AdicionarInimigo()
        {
            return View();
        }
        public ActionResult AdicionandoInimigo(Inimigo inimigo)
        {
            try
            {
                inimigo.Hp = inimigo.HpMax;
                inimigo.Mp = inimigo.MpMax;
                _context.Add(inimigo);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Ocorreu um erro: " + e.Message);
            }
            return View(inimigo);
        }

        public ActionResult VisualizarInimigo()
        {
            return View();
        }
        public ActionResult VisualizandoInimigo(int InimigoId)
        {
            Inimigo inimigo = null;
            try
            {
                inimigo = _context.Inimigos.FirstOrDefault(x => x.InimigoId == InimigoId);
            }
            catch (Exception e) { }
            if (inimigo is null)
            {
                //return View();
                return RedirectToAction("Index");
            }
            else
            {
                return View(inimigo);
            }
        }
        public ActionResult VisualizarTodosInimigos()
        {
            //System.Console.WriteLine("Informações dos jogadores: ");
            List<Inimigo> inimigos;
            try
            {
                inimigos = _context.Inimigos.ToList();
            }
            catch (Exception e)
            {
                //System.Console.WriteLine(e.Message);
                return View("Index");
            }

            //foreach (Jogador jogador in jogadores){System.Console.WriteLine(jogador.ToString());}

            return View(inimigos);
        }

        public ActionResult ModificarInimigo()
        {
            return View();
        }
        public ActionResult ModificandoInimigo(int InimigoId)
        {

            Inimigo inimigo = _context.Inimigos.FirstOrDefault(x => x.InimigoId == InimigoId);

            if (inimigo is null)
            {
                return View("Index");
            }

            return View(inimigo);

        }
        public ActionResult ModificadoInimigo(Inimigo inimigo)
        {
            if (inimigo is null)
            {
                return RedirectToAction("Index");
            }

            _context.Inimigos.Update(inimigo);
            _context.SaveChanges();

            return View(inimigo);
        }
        public ActionResult RemoverInimigo()
        {
            return View();
        }

        public ActionResult RemovendoInimigo(int InimigoId)
        {

            var inimigo = _context.Inimigos.SingleOrDefault(x => x.InimigoId == InimigoId);
            if (inimigo is null)
            {
                return Redirect("Index");
            }

            _context.Inimigos.Remove(inimigo);
            _context.SaveChanges();
            return View(inimigo);
        }
    }
}
