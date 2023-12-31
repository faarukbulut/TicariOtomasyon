﻿using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Models.Siniflar;
using TicariOtomasyon.Repositories.KategoriRepositories;
using TicariOtomasyon.Repositories.UrunDetayRepositories;
using TicariOtomasyon.Repositories.UrunRepositories;

namespace TicariOtomasyon.Controllers
{
    public class UrunController : Controller
    {
        private readonly IUrunRepository _urunRepository;
        private readonly IKategoriRepository _kategoriRepository;
        private readonly IUrunDetayRepository _urunDetayRepository;

        public UrunController(IUrunRepository urunRepository, IKategoriRepository kategoriRepository, IUrunDetayRepository urunDetayRepository)
        {
            _urunRepository = urunRepository;
            _kategoriRepository = kategoriRepository;
            _urunDetayRepository = urunDetayRepository;
        }

        public IActionResult Index()
        {
            var values = _urunRepository.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult UrunEkle()
        {
            ViewBag.Kategoriler = _kategoriRepository.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult UrunEkle(Urun urun)
        {
            urun.Durum = true;
            _urunRepository.Create(urun);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UrunDuzenle(int id)
        {
            ViewBag.Kategoriler = _kategoriRepository.GetAll();
            var value = _urunRepository.Get(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UrunDuzenle(Urun urun)
        {
            urun.Durum = true;
            _urunRepository.Update(urun);
            return RedirectToAction("Index");
        }

        public IActionResult UrunSil(int id)
        {
            var value = _urunRepository.Get(id);
            value.Durum = false;
            _urunRepository.Update(value);

            return RedirectToAction("Index");
        }

        public IActionResult UrunDetay(int id)
        {
            UrunList u = new UrunList();

            u.Deger1 = _urunRepository.GetAll().Where(x => x.UrunID == id);
            u.Deger2 = _urunDetayRepository.GetAll().Where(x => x.UrunDetayID == id);

            return View(u);
        }
    }
}
