using PRT.Appliction.Interface;
using PRT.Domain.Entitites;
using PRT.Domain.Interfaces.Services;

namespace PRT.Appliction
{
    public class UserAppService : AppServiceBase<User>, IUserAppService
    {
        private readonly IUserService _userService;

        public UserAppService(IUserService userService)
            :base(userService)
        {
            _userService = userService;
        }
    }
}
