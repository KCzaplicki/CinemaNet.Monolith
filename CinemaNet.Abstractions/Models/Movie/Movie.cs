namespace CinemaNet.Abstractions.Models.Movie;

public class Movie
{
    public string Id { get; init; }

    public string Name { get; init; }

    public int Duration { get; init; }

    public DateTime ReleaseDate { get; init; }

    public string Category { get; init; }

    public string Description { get; init; }
    
    public string PictureUrl { get; init; }
    
    public MovieScreenings[] Screenings { get; set; }
}