using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.SatisHareketRepositories
{
    public interface ISatisHareketRepository
    {
        List<SatisHareket> GetAll();
        SatisHareket Get(int id);
        void Create(SatisHareket satisHareket);
        void Update(SatisHareket satisHareket);
        List<SatisHareket> GetAllWithPersonel(int id);
        List<SatisHareket> GetAllWithCari(int id);
    }
}
