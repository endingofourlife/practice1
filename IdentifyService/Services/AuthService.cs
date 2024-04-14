namespace IdentifyService.Services;


public class AuthService
{
    public bool AuthenticateUser(string username, string password)
    {
        return username == "test" && password == "test";
    }
}