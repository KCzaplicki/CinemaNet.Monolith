using CinemaNet.Common.Persistence;

namespace CinemaNet.Persistence.Models;

public class Screening : AuditableEntity
{
    public string MovieId { get; set; }

    public string CinemaHallId { get; set; }
    
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
    
    
    public Movie Movie { get; set; }
    
    public CinemaHall CinemaHall { get; set; }
}