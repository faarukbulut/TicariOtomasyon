using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.UrunRepositories
{
    public interface IUrunRepository
    {
        List<Urun> GetAll();
        void Create(Urun urun);
        void Update(Urun urun);
        Urun Get(int id);
    }
}
