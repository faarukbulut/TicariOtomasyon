
using Microsoft.EntityFrameworkCore;
using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.PersonelRepositories
{
    public class PersonelRepository : IPersonelRepository
    {
        Context c = new Context();

        public List<Personel> GetAll()
        {
            var values = c.Personels.Include(x => x.Departman).ToList();
            return values;
        }

        public Personel Get(int id)
        {
            var value = c.Personels.Find(id);
            return value;
        }

        public void Create(Personel personel)
        {
            c.Personels.Add(personel);
            c.SaveChanges();
        }

        public void Update(Personel personel)
        {
            c.Personels.Update(personel);
            c.SaveChanges();
        }

        public List<Personel> GetAllWithDepartman(int id)
        {
            var values = c.Personels.Where(x => x.DepartmanID == id).ToList();
            return values;
        }
    }
}
