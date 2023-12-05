using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.SatisHareketRepositories
{
    public interface ISatisHareketRepository
    {
        List<SatisHareket> GetAllWithPersonel(int id);
        List<SatisHareket> GetAllWithCari(int id);
    }
}
