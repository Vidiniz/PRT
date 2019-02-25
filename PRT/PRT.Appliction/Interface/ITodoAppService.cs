using PRT.Domain.Entitites;
using System.Collections.Generic;

namespace PRT.Appliction.Interface
{
    public interface ITodoAppService : IAppServiceBase<Todo>
    {
        IEnumerable<Todo> GetByDescription(string description);

        IEnumerable<Todo> GetAllOrderByDescending(string field);
    }
}
