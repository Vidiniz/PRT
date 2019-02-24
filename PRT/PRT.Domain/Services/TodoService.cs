using PRT.Domain.Entitites;
using PRT.Domain.Interfaces.Repositories;
using PRT.Domain.Interfaces.Services;

namespace PRT.Domain.Services
{
    public class TodoService : ServiceBase<Todo>, ITodoService
    {
        private readonly ITodoRepository _todoRepository;

        public TodoService(ITodoRepository todoRepository)
            : base(todoRepository)
        {
            _todoRepository = todoRepository;
        }
    }   
}
