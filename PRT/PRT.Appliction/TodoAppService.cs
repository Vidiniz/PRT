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
    }   
}
