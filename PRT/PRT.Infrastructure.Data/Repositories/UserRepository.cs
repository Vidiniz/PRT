using PRT.Domain.Entitites;
using PRT.Domain.Interfaces.Repositories;

namespace PRT.Infrastructure.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
    }
}
