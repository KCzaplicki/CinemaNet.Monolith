namespace CinemaNet.Abstractions.Models.Movie;

public class MovieScreenings
{
    public DateTime Day { get; set; }

    public MovieScreening[] Screenings { get; set; }
}