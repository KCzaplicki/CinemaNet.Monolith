using CinemaNet.Common.Persistence;

namespace CinemaNet.Persistence.Models;

public class Staff : BaseEntity
{
    public string FirstName { get; set; }

    public string LastName { get; set; }
    
    
    public IEnumerable<MovieStaff> MovieStaves { get; set; }
}