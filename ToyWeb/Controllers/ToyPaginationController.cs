using Microsoft.AspNetCore.Mvc;
using ToyWeb.Services;


namespace ToyWeb.Controllers
{

    public class ToyPaginationController : Controller
    {
        private readonly IToyService operaService;

        public ToyPaginationController(IToyService operaService)
        {
            this.operaService = operaService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(operaService.GetToyPage(1));
        }

        [HttpPost]
        public IActionResult Index(int currentPageIndex)
        {
            return View(operaService.GetToyPage(currentPageIndex));
        }   

    }
}
