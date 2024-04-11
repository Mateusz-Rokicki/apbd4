namespace WebApplication1.Models;

public class Appointment
{
    public int Id { get; set; }
    
    public int IdStudent { get; set; }
    public Student Student { get; set; }
}