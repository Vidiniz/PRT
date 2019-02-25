using System.Collections.Generic;
using PRT.Appliction.Interface;
using PRT.Domain.Entitites;
using PRT.Domain.Interfaces.Services;

namespace PRT.Appliction
{
    public class TodoAppService  : AppServiceBase<Todo>, ITodoAppService
    {
        private readonly ITodoService _todoSerivce;

        public TodoAppService(ITodoService todoService)
            : base(todoService)
        {
            _todoSerivce = todoService;
        }

        public IEnumerable<Todo> GetAllOrderByDescending(string field)
        {
            return _todoSerivce.GetAllOrderByDescending(field);
        }

        public IEnumerable<Todo> GetByDescription(string description)
        {
            return _todoSerivce.GetByDescription(description);
        }
    }   
}
