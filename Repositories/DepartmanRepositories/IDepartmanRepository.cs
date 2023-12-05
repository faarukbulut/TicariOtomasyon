using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.DepartmanRepositories
{
    public interface IDepartmanRepository
    {
        List<Departman> GetAll();
        void Create(Departman departman);
        void Update(Departman departman);
        Departman Get(int id);
    }
}
