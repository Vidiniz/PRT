using PRT.Domain.Entitites;
using System.Collections.Generic;

namespace PRT.Domain.Interfaces.Repositories
{
    public interface ITodoRepository : IRepositoryBase<Todo>
    {
        IEnumerable<Todo> GetByDescription(string description);

        IEnumerable<Todo> GetAllOrderByDescending(string field);
    }

}
