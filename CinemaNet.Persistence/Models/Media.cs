using CinemaNet.Common.Persistence;

namespace CinemaNet.Persistence.Models;

public class Media : BaseEntity
{
    public string Url { get; set; }

    
    public Movie Movie { get; set; }
}