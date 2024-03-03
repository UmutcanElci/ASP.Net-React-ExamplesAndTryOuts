using BaseLibrary.DTOs;
using BaseLibrary.Responses;
using ServerLibrary.Repositories.Contracts;

namespace ServerLibrary.Repositories.Implementations;

public class UserAccountRepository : IUserAccount
{
    public Task<GeneralResponse> CreateAsync(Register user)
    {
        throw new NotImplementedException();
    }

    public Task<LoginResponse> SignInAsync(Login user)
    {
        throw new NotImplementedException();
    }
}