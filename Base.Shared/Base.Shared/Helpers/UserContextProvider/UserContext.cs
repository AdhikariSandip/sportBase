
namespace Base.Shared.Helpers.UserContextProvider;

public class UserContext : IUserContext
{
    private int UserId;
    private string UserName;
    public async Task<int> GetUserId()
    {
        return UserId;
    }

    public async Task<string> GetUserName()
    {
        return UserName;
    }

    public async Task SetUserId(int userId)
    {
        UserId = userId;
    }

    public async Task SetUserName(string userName)
    {
       UserName  = userName;
    }
}
