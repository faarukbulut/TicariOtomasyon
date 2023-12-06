using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.FaturaKalemsRepositories
{
    public class FaturaKalemRepository : IFaturaKalemRepository
    {
        Context c = new Context();

        public void Create(FaturaKalem faturaKalem)
        {
            c.FaturaKalems.Add(faturaKalem);
            c.SaveChanges();
        }

        public List<FaturaKalem> GetAllWithFatura(int id)
        {
            var values = c.FaturaKalems.Where(x => x.FaturaID == id).ToList();
            return values;
        }
    }
}
