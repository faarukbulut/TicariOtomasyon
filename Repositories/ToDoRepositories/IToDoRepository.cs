using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.ToDoRepositories
{
    public interface IToDoRepository
    {
        List<ToDo> GetAll();
        ToDo Get(int id);
        void Update(ToDo toDo);
    }
}
