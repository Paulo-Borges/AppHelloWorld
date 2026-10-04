using AppHelloWorld.Models.Users;
using AppHelloWorld.Services.RequestProvider;
using AppHelloWorld.Services.Users;

namespace AppHelloWorld.Services
{
    public class UserService(IRequestProvider requestProvider) : IUserService
    {
        private readonly IRequestProvider _requestProvider = requestProvider;
        public async Task<User> Add(User user)
        {
            var uri = GlobalSettings.Instance.UserEndpoint + "/add";
            return await _requestProvider.PostAsync(uri, user);
        }
    }
}
