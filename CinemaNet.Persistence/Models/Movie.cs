using CinemaNet.Common.Persistence;

namespace CinemaNet.Persistence.Models;

public class Movie : AuditableEntity
{
    public string Name { get; set; }

    public int Duration { get; set; }

    public string Description { get; set; }

    public DateTime ReleaseDate { get; set; }

    public string CategoryId { get; set; }

    public MovieState State { get; set; }
    
    
    public Category Category { get; set; }
    
    public IEnumerable<MovieStaff> Staff { get; set; }
    
    public IEnumerable<Media> Media { get; set; }
}