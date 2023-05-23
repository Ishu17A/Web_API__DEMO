using Web_API__DEMO.Models;

namespace Web_API__DEMO.Repository
{
    public interface IAccountRepository
    {
        Task<LoginResponse> SignUp(Register model);

        Task<LoginResponse> Login(Login model);
    }
}
