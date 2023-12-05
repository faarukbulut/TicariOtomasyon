using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models.Siniflar;
using TicariOtomasyon.Repositories.CariRepositories;
using TicariOtomasyon.Repositories.SatisHareketRepositories;

namespace TicariOtomasyon.Controllers
{
    public class CariController : Controller
    {
        private readonly ICariRepository _cariRepository;
        private readonly ISatisHareketRepository _satisHareketRepository;

        public CariController(ICariRepository cariRepository, ISatisHareketRepository satisHareketRepository)
        {
            _cariRepository = cariRepository;
            _satisHareketRepository = satisHareketRepository;
        }

        public IActionResult Index()
        {
            var values = _cariRepository.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult CariEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CariEkle(Cari cari)
        {
            cari.Durum = true;
            _cariRepository.Create(cari);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CariDuzenle(int id)
        {
            var value = _cariRepository.Get(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult CariDuzenle(Cari cari)
        {
            cari.Durum = true;
            _cariRepository.Update(cari);
            return RedirectToAction("Index");
        }

        public IActionResult CariSil(int id)
        {
            var value = _cariRepository.Get(id);
            value.Durum = false;
            _cariRepository.Update(value);

            return RedirectToAction("Index");
        }

        public IActionResult SatisGecmisi(int id)
        {
            var c = _cariRepository.Get(id);
            ViewBag.cari = c.CariAd + " " + c.CariSoyad;

            var values = _satisHareketRepository.GetAllWithCari(id);
            return View(values);
        }

    }
}
