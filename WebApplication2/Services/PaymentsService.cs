namespace WebApplication2.Services;

public class PaymentsService
{
    private readonly AuthService _authService;

    public PaymentsService(AuthService authService)
    {
        _authService = authService;
    }

    public bool ProcessPayment(int userId, decimal amount)
    {
        // if (!_authService.IsUserAuthenticated())
        // {
        //     return false;
        // }
        
        // here we add some real logic, but again it just returns true. 
        return true;
    }
}