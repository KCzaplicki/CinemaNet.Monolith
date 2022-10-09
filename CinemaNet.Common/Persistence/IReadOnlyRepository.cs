using System.Linq.Expressions;

namespace CinemaNet.Common.Persistence;

public interface IReadOnlyRepository<T> where T : BaseEntity
{
    IQueryable<T> GetAll();
    
    T Get(string id);

    bool Exists(string id);
}