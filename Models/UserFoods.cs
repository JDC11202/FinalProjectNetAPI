namespace FinalProjectNetAPI.Models;

public class UserFoods
{
    public int Id { get; set; }

    public int User_id { get; set; }
    
    public string FavFruit { get; set; }

    public string FavMeat { get; set; }

    public string FavCuisine { get; set; }

}