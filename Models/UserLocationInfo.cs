namespace FinalProjectNetAPI.Models;

public class UserLocationInfo
{
    public int Id { get; set; }
    public string State { get; set; }

    public string City { get; set; }
    
    public int AreaCode { get; set; } 
    
    public int ZipCode { get; set; }
}