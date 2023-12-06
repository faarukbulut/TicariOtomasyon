using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.FaturaRepositories
{
    public interface IFaturaRepository
    {
        List<Fatura> GetAll();
        Fatura Get(int id);
        void Create(Fatura fatura);
        void Update(Fatura fatura);
    }
}
