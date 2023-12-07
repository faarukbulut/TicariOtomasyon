using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models.Siniflar;
using TicariOtomasyon.Repositories.DepartmanRepositories;
using TicariOtomasyon.Repositories.PersonelRepositories;

namespace TicariOtomasyon.Controllers
{
    public class PersonelController : Controller
    {
        private readonly IPersonelRepository _personelRepository;
        private readonly IDepartmanRepository _departmanRepository;

        public PersonelController(IPersonelRepository personelRepository, IDepartmanRepository departmanRepository)
        {
            _personelRepository = personelRepository;
            _departmanRepository = departmanRepository;
        }

        public IActionResult Index()
        {
            var values = _personelRepository.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult PersonelEkle()
        {
            ViewBag.Departmanlar = _departmanRepository.GetAll();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PersonelEkle(Personel personel)
        {
            if(personel.PersonelGorsel2 != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(personel.PersonelGorsel2.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/Upload/images/personeller/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await personel.PersonelGorsel2.CopyToAsync(stream);

                personel.PersonelGorsel = imagename;
            }
            else
            {
                personel.PersonelGorsel = "";
            }

            _personelRepository.Create(personel);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult PersonelDuzenle(int id)
        {
            ViewBag.Departmanlar = _departmanRepository.GetAll();
            var value = _personelRepository.Get(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult PersonelDuzenle(Personel personel)
        {
            _personelRepository.Update(personel);
            return RedirectToAction("Index");
        }






    }
}
