﻿using Microsoft.EntityFrameworkCore;
using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.CariRepositories
{
    public class CariRepository : ICariRepository
    {
        Context c = new Context();

        public List<Cari> GetAll()
        {
            var values = c.Caris.Where(x => x.Durum).ToList();
            return values;
        }

        public void Create(Cari cari)
        {
            c.Caris.Add(cari);
            c.SaveChanges();
        }

        public Cari Get(int id)
        {
            var value = c.Caris.Find(id);
            return value;
        }

        public void Update(Cari cari)
        {
            c.Caris.Update(cari);
            c.SaveChanges();
        }
    }
}
