using Microsoft.EntityFrameworkCore;
using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.UrunRepositories
{
    public class UrunRepository : IUrunRepository
    {
        Context c = new Context();

        public List<Urun> GetAll()
        {
            var values = c.Uruns.Include(x => x.Kategori).Where(x => x.Durum == true).ToList();
            return values;
        }

        public Urun Get(int id)
        {
            var value = c.Uruns.Find(id);
            return value;
        }

        public void Create(Urun urun)
        {
            c.Uruns.Add(urun);
            c.SaveChanges();
        }

        public void Update(Urun urun)
        {
            c.Uruns.Update(urun);
            c.SaveChanges();
        }

    }
}
