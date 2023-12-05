using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.DepartmanRepositories
{
    public class DepartmanRepository : IDepartmanRepository
    {
        Context c = new Context();

        public List<Departman> GetAll()
        {
            var values = c.Departmans.Where(x => x.Durum == true).ToList();
            return values;
        }

        public void Create(Departman departman)
        {
            c.Departmans.Add(departman);
            c.SaveChanges();
        }

        public Departman Get(int id)
        {
            var value = c.Departmans.Find(id);
            return value;
        }

        public void Update(Departman departman)
        {
            c.Departmans.Update(departman);
            c.SaveChanges();
        }
    }
}
