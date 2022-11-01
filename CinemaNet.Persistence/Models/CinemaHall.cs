using CinemaNet.Common.Persistence;

namespace CinemaNet.Persistence.Models;

public class CinemaHall : AuditableEntity
{
    public string Name { get; set; }

    public string Type { get; set; }
    
    
    public IEnumerable<Screening> Screenings { get; set; }
}