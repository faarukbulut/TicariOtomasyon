using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.PersonelRepositories
{
    public interface IPersonelRepository
    {
        List<Personel> GetAll();
        Personel Get(int id);
        void Create(Personel personel);
        void Update(Personel personel);
        List<Personel> GetAllWithDepartman(int id);
    }
}
