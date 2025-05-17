namespace Base.Shared.Helpers.UserContextProvider;

public interface IUserContext
{
    Task SetUserId(int userId);
    Task SetUserName(string userName);
    Task<int> GetUserId();
    Task<string> GetUserName();
}
