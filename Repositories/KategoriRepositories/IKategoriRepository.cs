using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.KategoriRepositories
{
    public interface IKategoriRepository
    {
        List<Kategori> GetAll();
        Kategori Get(int id);
        void Create(Kategori kategori);
        void Update(Kategori kategori);
        void Delete(int id);
    }
}
