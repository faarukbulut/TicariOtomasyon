using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models.Siniflar;
using TicariOtomasyon.Repositories.KategoriRepositories;

namespace TicariOtomasyon.Controllers
{
	public class KategoriController : Controller
	{
		private readonly IKategoriRepository _kategoriRepository;

        public KategoriController(IKategoriRepository kategoriRepository)
        {
            _kategoriRepository = kategoriRepository;
        }

        public IActionResult Index()
		{
			var values = _kategoriRepository.GetAll();
			return View(values);
		}

		[HttpGet]
		public IActionResult KategoriEkle()
		{
			return View();
		}

		[HttpPost]
		public IActionResult KategoriEkle(Kategori kategori)
		{
			_kategoriRepository.Create(kategori);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult KategoriDuzenle(int id)
		{
			var value = _kategoriRepository.Get(id);
			return View(value);
		}

		[HttpPost]
		public IActionResult KategoriDuzenle(Kategori kategori)
		{
			_kategoriRepository.Update(kategori);
			return RedirectToAction("Index");
		}

		public IActionResult KategoriSil(int id)
		{
			_kategoriRepository.Delete(id);
			return RedirectToAction("Index");
		}
	}
}
