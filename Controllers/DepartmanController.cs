using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models.Siniflar;
using TicariOtomasyon.Repositories.DepartmanRepositories;
using TicariOtomasyon.Repositories.PersonelRepositories;
using TicariOtomasyon.Repositories.SatisHareketRepositories;

namespace TicariOtomasyon.Controllers
{
    public class DepartmanController : Controller
    {
        private readonly IDepartmanRepository _departmanRepository;
        private readonly IPersonelRepository _personelRepository;
        private readonly ISatisHareketRepository _satisHareketRepository;

        public DepartmanController(IDepartmanRepository departmanRepository, IPersonelRepository personelRepository, ISatisHareketRepository satisHareketRepository)
        {
            _departmanRepository = departmanRepository;
            _personelRepository = personelRepository;
            _satisHareketRepository = satisHareketRepository;
        }

        public IActionResult Index()
        {
            var values = _departmanRepository.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult DepartmanEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DepartmanEkle(Departman departman)
        {
            departman.Durum = true;
            _departmanRepository.Create(departman);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DepartmanDuzenle(int id)
        {
            var value = _departmanRepository.Get(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult DepartmanDuzenle(Departman departman)
        {
            departman.Durum = true;
            _departmanRepository.Update(departman);
            return RedirectToAction("Index");
        }

        public IActionResult DepartmanSil(int id)
        {
            var value = _departmanRepository.Get(id);
            value.Durum = false;
            _departmanRepository.Update(value);

            return RedirectToAction("Index");
        }

        public IActionResult DepartmanDetay(int id)
        {
            var dpt = _departmanRepository.Get(id);
            ViewBag.departman = dpt.DepartmanAd;

            var values = _personelRepository.GetAllWithDepartman(id);
            return View(values);
        }

        public IActionResult DepartmanPersonelSatis(int id)
        {
            var per = _personelRepository.Get(id);
            ViewBag.personel = per.PersonelAd + " " + per.PersonelSoyad;

            var values = _satisHareketRepository.GetAllWithPersonel(id);
            return View(values);
        }
    }
}
