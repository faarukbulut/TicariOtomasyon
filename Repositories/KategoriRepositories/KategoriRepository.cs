using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.KategoriRepositories
{
    public class KategoriRepository : IKategoriRepository
    {
        Context c = new Context();

        public List<Kategori> GetAll()
        {
            var values = c.Kategoris.ToList();
            return values;
        }

        public Kategori Get(int id)
        {
            var value = c.Kategoris.Find(id);
            return value;
        }

        public void Create(Kategori kategori)
        {
            c.Kategoris.Add(kategori);
            c.SaveChanges();
        }

        public void Update(Kategori kategori)
        {
            c.Kategoris.Update(kategori);
            c.SaveChanges();
        }

        public void Delete(int id)
        {
            var value = c.Kategoris.Find(id);
            c.Kategoris.Remove(value);
            c.SaveChanges();
        }
    }
}
