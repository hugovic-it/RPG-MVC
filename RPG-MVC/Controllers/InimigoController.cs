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
    }
}
