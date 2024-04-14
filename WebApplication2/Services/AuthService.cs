namespace WebApplication2.Services;

public class AuthService
{
    private int _callCount = 0;
    public bool AuthenticateUser(string username, string password)
    {
        // Simulate 50/50 chance with alternating success. =)
        _callCount++;
        return _callCount % 2 == 0; // Even call count returns true, odd returns false
    }
}
