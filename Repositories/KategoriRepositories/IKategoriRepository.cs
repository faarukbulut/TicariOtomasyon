using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.KategoriRepositories
{
    public interface IKategoriRepository
    {
        List<Kategori> GetAll();
        void Create(Kategori kategori);
        void Delete(int id);
        void Update(Kategori kategori);
        Kategori Get(int id);
    }
}
