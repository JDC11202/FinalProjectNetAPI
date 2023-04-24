namespace FinalProjectNetAPI.Models;

public class BasicUserInfo
{
    public int ID { get; set; }
    
    public string Name { get; set; }

    public DateOnly Birthdate { get; set; }
    
    public string Major { get; set; } 
    
    public int year { get; set; }
}