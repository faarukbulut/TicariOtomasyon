using Microsoft.AspNetCore.Mvc;
using TicariOtomasyon.Repositories.ToDoRepositories;

namespace TicariOtomasyon.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IToDoRepository _toDoRepository;

        public ToDoController(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        public IActionResult Index()
        {
            var values = _toDoRepository.GetAll();
            return View(values);
        }
    }
}
