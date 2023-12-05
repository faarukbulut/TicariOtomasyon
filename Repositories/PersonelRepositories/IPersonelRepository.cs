using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.PersonelRepositories
{
    public interface IPersonelRepository
    {
        List<Personel> GetAllWithDepartman(int id);
        Personel Get(int id);
    }
}
