using CinemaNet.Common.Persistence;

namespace CinemaNet.Persistence.Models;

public class CinemaHallRow : BaseEntity
{
    public CinemaHallRowType Type { get; set; }
    
    public char Letter { get; set; }
    
    public int Seats { get; set; }
    
    public string CinemaHallId { get; set; }
    
    
    public CinemaHall CinemaHall { get; set; }
}