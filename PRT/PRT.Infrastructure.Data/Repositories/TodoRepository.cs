using System;
using System.Collections.Generic;
using System.Linq;
using PRT.Domain.Entitites;
using PRT.Domain.Interfaces.Repositories;

namespace PRT.Infrastructure.Data.Repositories
{
    public class TodoRepositor : RepositoryBase<Todo>, ITodoRepository
    {
        public IEnumerable<Todo> GetByDescription(string description)
        {
            return DataBase.Set<Todo>().Where(t => t.Description.Contains(description))
                .OrderByDescending(t => t.CreatedAt)
                .ToList();
        }

        public IEnumerable<Todo> GetAllOrderByDescending(string field)
        {
            return DataBase.Set<Todo>()
                .OrderByDescending(t => typeof(Todo).GetProperty(field))
                .ToList();
        }
    }
}
