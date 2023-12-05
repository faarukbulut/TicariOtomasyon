
using Microsoft.EntityFrameworkCore;
using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.SatisHareketRepositories
{
    public class SatisHareketRepository : ISatisHareketRepository
    {
        Context c = new Context();

        public List<SatisHareket> GetAllWithPersonel(int id)
        {
            var values = c.SatisHarekets.Include(x => x.Urun).Include(x => x.Cari).Where(x => x.PersonelID == id).ToList();
            return values;
        }
    }
}
