using CinemaNet.Common.Persistence;

namespace CinemaNet.Persistence.Models;

public class CinemaHall : AuditableEntity
{
    public string Name { get; set; }

    public IEnumerable<Screening> Screenings { get; set; }
    
    public IEnumerable<CinemaHallRow> Rows { get; set; }
}