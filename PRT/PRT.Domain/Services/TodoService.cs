using PRT.Domain.Entitites;
using PRT.Domain.Interfaces.Repositories;
using PRT.Domain.Interfaces.Services;
using System.Collections.Generic;

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

        public IEnumerable<Todo> GetAllOrderByDescending(string field)
        {
            return _todoRepository.GetAllOrderByDescending(field);
        }

        public IEnumerable<Todo> GetByDescription (string description)
        {
            return _todoRepository.GetByDescription(description);
        }
    }   
}
