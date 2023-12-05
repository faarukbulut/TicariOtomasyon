using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.KategoriRepositories
{
    public interface IKategoriRepository
    {
        List<Kategori> GetAllKategori();
        void CreateKategori(Kategori kategori);
        void DeleteKategori(int id);
        void UpdateKategori(Kategori kategori);
        Kategori GetKategori(int id);
    }
}
