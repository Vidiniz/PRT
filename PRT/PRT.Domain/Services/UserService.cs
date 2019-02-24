using PRT.Domain.Entitites;
using PRT.Domain.Interfaces.Repositories;
using PRT.Domain.Interfaces.Services;

namespace PRT.Domain.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        private readonly IUserRepository _userRespository;

        public UserService(IUserRepository userRespository)
            :base(userRespository)
        {
            _userRespository = userRespository;
        }
    }
}
