using CinemaNet.Common.Persistence;

namespace CinemaNet.Persistence.Models;

public class Category : BaseEntity
{
    public string Name { get; set; }
    
    public IEnumerable<Movie> Movies { get; set; }
}