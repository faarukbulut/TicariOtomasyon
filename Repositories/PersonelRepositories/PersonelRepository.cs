
using Microsoft.EntityFrameworkCore;
using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.PersonelRepositories
{
    public class PersonelRepository : IPersonelRepository
    {
        Context c = new Context();

        public List<Personel> GetAllWithDepartman(int id)
        {
            var values = c.Personels.Where(x => x.DepartmanID == id).ToList();
            return values;
        }

        public Personel Get(int id)
        {
            var value = c.Personels.Find(id);
            return value;
        }
    }
}
