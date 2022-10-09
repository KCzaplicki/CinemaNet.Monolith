namespace CinemaNet.Persistence.Models;

public class MovieStaff
{
    public string Role { get; set; }
 
    public string MovieId { get; set; }
    
    public string StaffId { get; set; }
    
    public Movie Movie { get; set; }

    public Staff Staff { get; set; }
}