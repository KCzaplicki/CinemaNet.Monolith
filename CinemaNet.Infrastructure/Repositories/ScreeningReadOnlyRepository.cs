using CinemaNet.Abstractions.Repositories;
using CinemaNet.Infrastructure.Persistence;
using CinemaNet.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaNet.Infrastructure.Repositories;

public class ScreeningReadOnlyRepository : IScreeningReadOnlyRepository
{
    private readonly DbSet<Screening> _screenings;

    public ScreeningReadOnlyRepository(CinemaNetContext context)
    {
        _screenings = context.Screenings;
    }
    
    public IQueryable<Screening> GetAll() => _screenings;

    public Screening Get(string id) => 
        _screenings.FirstOrDefault(s => s.Id == id);

    public bool Exists(string id) => 
        _screenings.Any(m => m.Id == id);

    public Screening GetScreeningDetails(string id) =>
        _screenings
            .Include(s => s.Movie)
            .Include(s => s.CinemaHall)
            .ThenInclude(c => c.Rows)
            .FirstOrDefault(s => s.Id == id);
}