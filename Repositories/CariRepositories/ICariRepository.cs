using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.CariRepositories
{
    public interface ICariRepository
    {
        List<Cari> GetAll();
        Cari Get(int id);
        void Create(Cari cari);
        void Update(Cari cari);
    }
}
