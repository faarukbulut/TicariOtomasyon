using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Repositories.UrunRepositories;

namespace TicariOtomasyon.Controllers
{
    public class GaleriController : Controller
    {
        private readonly IUrunRepository _urunRepository;

        public GaleriController(IUrunRepository urunRepository)
        {
            _urunRepository = urunRepository;
        }

        public IActionResult Index()
        {
            var values = _urunRepository.GetAll();
            return View(values);
        }
    }
}
