using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TicariOtomasyon.Models.Siniflar;
using TicariOtomasyon.Repositories.CariRepositories;
using TicariOtomasyon.Repositories.PersonelRepositories;
using TicariOtomasyon.Repositories.SatisHareketRepositories;
using TicariOtomasyon.Repositories.UrunRepositories;

namespace TicariOtomasyon.Controllers
{
    public class SatisController : Controller
    {
        private readonly ISatisHareketRepository _satisHareketRepository;
        private readonly IUrunRepository _urunRepository;
        private readonly ICariRepository _cariRepository;
        private readonly IPersonelRepository _personelRepository;

        public SatisController(ISatisHareketRepository satisHareketRepository, IUrunRepository urunRepository, ICariRepository cariRepository, IPersonelRepository personelRepository)
        {
            _satisHareketRepository = satisHareketRepository;
            _urunRepository = urunRepository;
            _cariRepository = cariRepository;
            _personelRepository = personelRepository;
        }

        public IActionResult Index()
        {
            var values = _satisHareketRepository.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult SatisEkle()
        {
            List<SelectListItem> carivalues = (from x in _cariRepository.GetAll() select new SelectListItem
            {
                Text = x.CariAd + " " + x.CariSoyad,
                Value = x.CariID.ToString()
            }).ToList();

            List<SelectListItem> personelValues = (from x in _personelRepository.GetAll() select new SelectListItem
            {
                Text = x.PersonelAd + " " + x.PersonelSoyad,
                Value = x.PersonelID.ToString()
            }).ToList();

            ViewBag.Urunler = _urunRepository.GetAll();
            ViewBag.Cariler = carivalues;
            ViewBag.Personeller = personelValues;
            return View();
        }

        [HttpPost]
        public IActionResult SatisEkle(SatisHareket satisHareket)
        {
            var urunValues = _urunRepository.Get(satisHareket.UrunID);

            if(urunValues.Stok >= satisHareket.Adet)
            {
                urunValues.Stok -= (short)satisHareket.Adet;
                _urunRepository.Update(urunValues);

                _satisHareketRepository.Create(satisHareket);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult SatisDuzenle(int id)
        {
            List<SelectListItem> carivalues = (from x in _cariRepository.GetAll()
                                               select new SelectListItem
                                               {
                                                   Text = x.CariAd + " " + x.CariSoyad,
                                                   Value = x.CariID.ToString()
                                               }).ToList();

            List<SelectListItem> personelValues = (from x in _personelRepository.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.PersonelAd + " " + x.PersonelSoyad,
                                                       Value = x.PersonelID.ToString()
                                                   }).ToList();

            ViewBag.Urunler = _urunRepository.GetAll();
            ViewBag.Cariler = carivalues;
            ViewBag.Personeller = personelValues;

            var value = _satisHareketRepository.Get(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult SatisDuzenle(SatisHareket satisHareket)
        {
            _satisHareketRepository.Update(satisHareket);
            return RedirectToAction("Index");
        }

        public IActionResult SatisYazdir()
        {
            var values = _satisHareketRepository.GetAll();
            return View(values);
        }
    }
}
