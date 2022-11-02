using CinemaNet.Common.Persistence;
using CinemaNet.Persistence.Models;

namespace CinemaNet.Abstractions.Repositories;

public interface IScreeningReadOnlyRepository : IReadOnlyRepository<Screening>
{
    Screening GetScreeningDetails(string id);
}