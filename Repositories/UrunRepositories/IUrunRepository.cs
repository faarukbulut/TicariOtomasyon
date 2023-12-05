using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.UrunRepositories
{
    public interface IUrunRepository
    {
        List<Urun> GetAll();
        Urun Get(int id);
        void Create(Urun urun);
        void Update(Urun urun);
        
    }
}
