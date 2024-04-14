namespace WebApplication2.Models;

public class Subscription
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Plan { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}