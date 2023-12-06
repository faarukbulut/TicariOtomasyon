using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.FaturaKalemsRepositories
{
    public interface IFaturaKalemRepository
    {
        void Create(FaturaKalem faturaKalem);
        List<FaturaKalem> GetAllWithFatura(int id);
    }
}
