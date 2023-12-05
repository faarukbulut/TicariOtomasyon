using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.CariRepositories
{
    public interface ICariRepository
    {
        List<Cari> GetAll();
        void Create(Cari cari);
        void Update(Cari cari);
        Cari Get(int id);
    }
}
