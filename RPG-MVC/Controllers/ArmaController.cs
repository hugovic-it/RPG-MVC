using Microsoft.AspNetCore.Mvc;
using RPG_MVC.Context;

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
    }
}
