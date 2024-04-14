namespace SubscriptionsService.Services;

public class SubscriptionsService
{
    private readonly HttpClient _httpClient;

    public SubscriptionsService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<bool> SubscribeUser(int userId, string plan, string token)
    {
        // Викликаємо сервіс автентифікації для перевірки прав доступу користувача
        var isAuthenticated = await CallIdentifyService(token);
        if (!isAuthenticated)
        {
            return false; // Повертаємо false, якщо автентифікація не пройшла
        }

        // Логіка підписки користувача
        return true;
    }

    private async Task<bool> CallIdentifyService(string token)
    {
        var handler = new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
        };
    
        var httpClient = new HttpClient(handler);
        
        // Викликаємо IdentifyService для перевірки автентифікації
        // Ваш URL для IdentifyService
        var identifyServiceUrl = "https://localhost:7165/api/auth/verify";

        // Виконуємо HTTP запит для перевірки автентифікації
        // Запит може виглядати як POST або GET, залежно від вашої реалізації IdentifyService
        var request = new HttpRequestMessage(HttpMethod.Get, identifyServiceUrl);
        request.Headers.Add("Authorization", $"Bearer {token}");

        var response = await httpClient.SendAsync(request);

        
        return true; // Користувач автентифікований
       
    }
}