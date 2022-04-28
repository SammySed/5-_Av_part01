using _5º_Av_part01.Data;
using _5º_Av_part01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _5º_Av_part01.Controllers
{
    public class ClienteController : Controller
    {
        private readonly _5º_Av_part01.Data.AppCont _appCont;

        public ClienteController(_5º_Av_part01.Data.AppCont appCont)
        {
            _appCont = appCont;
        }

        //GET: Produtocontroller

        public async Task<ActionResult> Index()
        {
            var allProducts = await _appCont.Clientes.ToListAsync();
            return View(allProducts);
        }

        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Cliente cliente)
        {                  
            _appCont.Clientes.Add(cliente);
            await _appCont.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
