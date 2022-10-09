namespace CinemaNet.Abstractions.Models.Movie;

public class MovieDetails
{
    public string Id { get; init; }

    public string Name { get; init; }

    public int Duration { get; init; }

    public DateTime ReleaseDate { get; init; }

    public string Category { get; init; }

    public string Description { get; init; }

    public string[] MediaUrls { get; init; }

    public string Director { get; init; }
    
    public string[] Staff { get; init; }
}