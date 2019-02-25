using PRT.Domain.Entitites;
using System.Collections.Generic;

namespace PRT.Domain.Interfaces.Services
{
    public interface ITodoService : IServiceBase<Todo>
    {
        IEnumerable<Todo> GetByDescription(string description);

        IEnumerable<Todo> GetAllOrderByDescending(string field);
    }
}
