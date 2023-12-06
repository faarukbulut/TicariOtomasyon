using Microsoft.EntityFrameworkCore;
using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.UrunDetayRepositories
{
    public class UrunDetayRepository : IUrunDetayRepository
    {
        Context c = new Context();

        public List<UrunDetay> GetAll()
        {
            var values = c.UrunDetays.ToList();
            return values;
        }
    }
}
