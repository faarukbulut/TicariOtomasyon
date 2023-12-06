using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models.Siniflar;
using TicariOtomasyon.Repositories.FaturaKalemsRepositories;
using TicariOtomasyon.Repositories.FaturaRepositories;

namespace TicariOtomasyon.Controllers
{
    public class FaturaController : Controller
    {
        private readonly IFaturaRepository _faturaRepository;
        private readonly IFaturaKalemRepository _faturaKalemRepository;

        public FaturaController(IFaturaRepository faturaRepository, IFaturaKalemRepository faturaKalemRepository)
        {
            _faturaRepository = faturaRepository;
            _faturaKalemRepository = faturaKalemRepository;
        }

        public IActionResult Index()
        {
            var values = _faturaRepository.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult FaturaEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FaturaEkle(Fatura fatura)
        {
            _faturaRepository.Create(fatura);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult FaturaDuzenle(int id)
        {
            var value = _faturaRepository.Get(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult FaturaDuzenle(Fatura fatura)
        {
            _faturaRepository.Update(fatura);
            return RedirectToAction("Index");
        }

        public IActionResult FaturaDetay(int id)
        {
            ViewBag.FaturaID = id;
            var values = _faturaKalemRepository.GetAllWithFatura(id);
            return View(values);
        }

        [HttpGet]
        public IActionResult FaturaKalemEkle(int id)
        {
            ViewBag.FaturaID = id;
            return View();
        }

        [HttpPost]
        public IActionResult FaturaKalemEkle(FaturaKalem faturaKalem)
        {
            _faturaKalemRepository.Create(faturaKalem);
            return RedirectToAction("Index");
        }



    }
}
