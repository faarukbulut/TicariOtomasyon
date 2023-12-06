using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TicariOtomasyon.Models.Siniflar;
using TicariOtomasyon.Repositories.AdminRepositories;
using TicariOtomasyon.Repositories.CariRepositories;

namespace TicariOtomasyon.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly ICariRepository _cariRepository;
        private readonly IAdminRepository _adminRepository;

		public LoginController(ICariRepository cariRepository, IAdminRepository adminRepository)
		{
			_cariRepository = cariRepository;
			_adminRepository = adminRepository;
		}

		public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CariKayit(Cari cari)
        {
            _cariRepository.Create(cari);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CariGiris(Cari cari)
        {
            var values = _cariRepository.GetForLogin(cari);

            if(values != null)
            {
				var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name, cari.CariMail),
				};

				var useridentity = new ClaimsIdentity(claims, "a");
				ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
				await HttpContext.SignInAsync(principal);
				return RedirectToAction("Index", "CariPanel");
			}

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> PersonelGiris(Admin admin)
        {
            var values = _adminRepository.GetForLogin(admin);

            if(values != null )
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, admin.KullaniciAd),
                };

                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Kategori");
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Cikis()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}
