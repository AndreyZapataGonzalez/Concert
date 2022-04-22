using Concert.Data;
using Concert.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Concert.Controllers
{
    public class TicketsController : Controller
    {
        private readonly DataContext _context;

        public TicketsController(DataContext context)
        {
            _context = context;
        }

        //public async Task<IActionResult> Index()
        //{
            //return View(Ticket); falta tickets controller
        //}

    }
}
