using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models.Siniflar;
using TicariOtomasyon.Repositories.CariRepositories;
using TicariOtomasyon.Repositories.SatisHareketRepositories;

namespace TicariOtomasyon.Controllers
{
	public class CariPanelController : Controller
	{
		private readonly ICariRepository _cariRepository;
		private readonly ISatisHareketRepository _satisHareketRepository;

        public CariPanelController(ICariRepository cariRepository, ISatisHareketRepository satisHareketRepository)
        {
            _cariRepository = cariRepository;
            _satisHareketRepository = satisHareketRepository;
        }

        [HttpGet]
		public IActionResult Index()
		{
			var value = _cariRepository.GetAll().Where(x => x.CariMail == User.Identity.Name).FirstOrDefault();
			return View(value);
		}

		[HttpPost]
		public IActionResult Index(Cari cari)
		{
			_cariRepository.Update(cari);
			return RedirectToAction("Index");
		}

		public IActionResult Siparislerim()
		{
			var cariId = _cariRepository.GetAll().Where(x => x.CariMail == User.Identity.Name).Select(x => x.CariID).FirstOrDefault();
			var values = _satisHareketRepository.GetAllWithCari(cariId);
			return View(values);
		}

		public async Task<IActionResult> Cikis()
		{
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Login");
		}


	}
}
