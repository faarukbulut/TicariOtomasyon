using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.FaturaRepositories
{
    public class FaturaRepository : IFaturaRepository
    {
        Context c = new Context();

        public List<Fatura> GetAll()
        {
            var values = c.Faturas.ToList();
            return values;
        }

        public Fatura Get(int id)
        {
            var value = c.Faturas.Find(id);
            return value;
        }

        public void Create(Fatura fatura)
        {
            c.Faturas.Add(fatura);
            c.SaveChanges();
        }

        public void Update(Fatura fatura)
        {
            c.Faturas.Update(fatura);
            c.SaveChanges();
        }
    }
}
