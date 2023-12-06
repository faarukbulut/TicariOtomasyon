using Microsoft.EntityFrameworkCore;
using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Repositories.ToDoRepositories
{
    public class ToDoRepository : IToDoRepository
    {
        Context c = new Context();

        public List<ToDo> GetAll()
        {
            var values = c.ToDos.ToList();
            return values;
        }

        public ToDo Get(int id)
        {
            var value = c.ToDos.Find(id);
            return value;
        }

        public void Update(ToDo toDo)
        {
            c.ToDos.Update(toDo);
            c.SaveChanges();
        }
    }
}
