namespace CinemaNet.Abstractions.Models.Screening;

public class Screening
{
    public string Id { get; init; }
    
    public DateTime StartDate { get; init; }

    public DateTime EndDate { get; init; }
    
    public string MovieName { get; set; }
    
    public string CinemaHallName { get; init; }
    
    public ScreeningCinemaHallRow[] CinemaHallRows { get; init; }
}