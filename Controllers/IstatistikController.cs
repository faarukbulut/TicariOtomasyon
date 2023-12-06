using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Repositories.CariRepositories;
using TicariOtomasyon.Repositories.KategoriRepositories;
using TicariOtomasyon.Repositories.PersonelRepositories;
using TicariOtomasyon.Repositories.SatisHareketRepositories;
using TicariOtomasyon.Repositories.UrunRepositories;

namespace TicariOtomasyon.Controllers
{
    public class IstatistikController : Controller
    {
        private readonly ICariRepository _cariRepository;
        private readonly IUrunRepository _urunRepository;
        private readonly IPersonelRepository _personelRepository;
        private readonly IKategoriRepository _kategoriRepository;
        private readonly ISatisHareketRepository _satisHareketRepository;

        public IstatistikController(ICariRepository cariRepository, IUrunRepository urunRepository, IPersonelRepository personelRepository, IKategoriRepository kategoriRepository, ISatisHareketRepository satisHareketRepository)
        {
            _cariRepository = cariRepository;
            _urunRepository = urunRepository;
            _personelRepository = personelRepository;
            _kategoriRepository = kategoriRepository;
            _satisHareketRepository = satisHareketRepository;
        }

        public IActionResult Index()
        {
            ViewBag.d1 = _cariRepository.GetAll().Count();
            ViewBag.d2 = _urunRepository.GetAll().Count();
            ViewBag.d3 = _personelRepository.GetAll().Count();
            ViewBag.d4 = _kategoriRepository.GetAll().Count();
            ViewBag.d5 = _urunRepository.GetAll().Sum(x => x.Stok);
            ViewBag.d6 = _urunRepository.GetAll().Select(x => x.Marka).Distinct().Count();
            ViewBag.d7 = _urunRepository.GetAll().Count(x => x.Stok < 20);
            ViewBag.d8 = _urunRepository.GetAll().OrderByDescending(x => x.SatisFiyat).Select(x => x.UrunAd).FirstOrDefault();
            ViewBag.d9 = _urunRepository.GetAll().OrderBy(x => x.SatisFiyat).Select(x => x.UrunAd).FirstOrDefault();
            ViewBag.d10 = _urunRepository.GetAll().GroupBy(x => x.Marka).OrderByDescending(x => x.Count()).Select(x => x.Key).FirstOrDefault();
            ViewBag.d11 = _urunRepository.GetAll().Count(x => x.UrunAd == "Buzdolabı");
            ViewBag.d12 = _urunRepository.GetAll().Count(x => x.UrunAd == "Laptop");
            ViewBag.d13 = _urunRepository.GetAll().Where(x => x.UrunID == _satisHareketRepository.GetAll().GroupBy(x => x.UrunID).OrderByDescending(x => x.Count()).Select(x => x.Key).FirstOrDefault()).Select(x => x.UrunAd).FirstOrDefault();
            ViewBag.d14 = _satisHareketRepository.GetAll().Sum(x => x.ToplamTutar);
            ViewBag.d15 = _satisHareketRepository.GetAll().Count(x => x.Tarih == DateTime.Today);
            ViewBag.d16 = _satisHareketRepository.GetAll().Where(x => x.Tarih == DateTime.Today).Sum(x => x.ToplamTutar);
            return View();
        }
    }
}
