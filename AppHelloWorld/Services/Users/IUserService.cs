using AppHelloWorld.Models.Users;

namespace AppHelloWorld.Services.Users
{
    public interface IUserService
    {
        Task<User> Add(User user);
    }
}
