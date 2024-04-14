namespace WebApplication2.Services;

public class SubscriptionsService
{
    private readonly AuthService _authService;

    public SubscriptionsService(AuthService authService)
    {
        _authService = authService;
    }

    public bool SubscribeUser(int userId, string plan)
    {
        // if (!_authService.IsUserAuthenticated())
        // {
        //     return false;
        // }

        // here we add some real logic, but again it just returns true. 
        return true; 
    }
}
