using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models.Siniflar;
using TicariOtomasyon.Repositories.UrunDetayRepositories;
using TicariOtomasyon.Repositories.UrunRepositories;

namespace TicariOtomasyon.Controllers
{
    public class UrunDetayController : Controller
    {
        private readonly IUrunRepository _urunRepository;
        private readonly IUrunDetayRepository _urunDetayRepository;

        public UrunDetayController(IUrunRepository urunRepository, IUrunDetayRepository urunDetayRepository)
        {
            _urunRepository = urunRepository;
            _urunDetayRepository = urunDetayRepository;
        }

        public IActionResult Index(int id)
        {
            UrunList u = new UrunList();

            u.Deger1 = _urunRepository.GetAll().Where(x => x.UrunID == id);
            u.Deger2 = _urunDetayRepository.GetAll().Where(x => x.UrunDetayID == id);

            return View(u);
        }
    }
}
