using Microsoft.AspNetCore.Mvc;
using RPG_MVC.Context;
using RPG_MVC.Models;

namespace RPG_MVC.Controllers
{
    public class ArmaController : Controller
    {
        private readonly AppDbContext _context;

        public ArmaController(AppDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AdicionarArma()
        {
            return View();
        }
        public ActionResult AdicionandoArma(Arma arma)
        {
            if (arma == null)
            {
                return View("Index");
            }
            try
            {
                _context.Armas.Add(arma);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
            }
            return View(arma);
        }

        public ActionResult VisualizarTodasArmas()
        {
            List<Arma> armas;
            try
            {
                armas = _context.Armas.ToList();
            }
            catch (Exception e)
            {
                return View("Index");
            }
            return View(armas);
        }

        public ActionResult VisualizarArma()
        {
            return View();
        }
        public ActionResult VisualizandoArma(int ArmaId)
        {
            Arma arma = null;
            try
            {
                arma = _context.Armas.FirstOrDefault(x => x.ArmaId == ArmaId);
            }
            catch (Exception e) { }
            if (arma is null)
            {
                return View();
            }
            else
            {
                return View(arma);
            }
        }


    }
}
