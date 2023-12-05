using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.DepartmanRepositories
{
    public interface IDepartmanRepository
    {
        List<Departman> GetAll();
        Departman Get(int id);
        void Create(Departman departman);
        void Update(Departman departman);
    }
}
