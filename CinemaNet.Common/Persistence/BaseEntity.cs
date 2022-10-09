using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaNet.Common.Persistence;

public abstract class BaseEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string Id { get; set; }
}