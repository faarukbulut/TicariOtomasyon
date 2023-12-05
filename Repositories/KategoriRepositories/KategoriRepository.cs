using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.KategoriRepositories
{
    public class KategoriRepository : IKategoriRepository
    {
        Context c = new Context();

        public List<Kategori> GetAllKategori()
        {
            var values = c.Kategoris.ToList();
            return values;
        }

        public void CreateKategori(Kategori kategori)
        {
            c.Kategoris.Add(kategori);
            c.SaveChanges();
        }

        public void DeleteKategori(int id)
        {
            var value = c.Kategoris.Find(id);
            c.Kategoris.Remove(value);
            c.SaveChanges();
        }

        public Kategori GetKategori(int id)
        {
            var value = c.Kategoris.Find(id);
            return value;
        }

        public void UpdateKategori(Kategori kategori)
        {
            c.Kategoris.Update(kategori);
            c.SaveChanges();
        }
    }
}
