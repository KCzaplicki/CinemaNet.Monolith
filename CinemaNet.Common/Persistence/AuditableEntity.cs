namespace CinemaNet.Common.Persistence;

public class AuditableEntity : BaseEntity
{
    public DateTime CreationDate { get; set; }
    
    public DateTime? UpdateDate { get; set; }
}