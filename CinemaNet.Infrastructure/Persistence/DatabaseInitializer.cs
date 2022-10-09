using CinemaNet.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaNet.Infrastructure.Persistence;

public static class DatabaseInitializer
{
    public static async Task InitializeAsync(CinemaNetContext context)
    {
        if (context.Movies.Any())
        {
            return;
        }

        await using var transaction = await context.Database.BeginTransactionAsync();
        try
        {
            await AddCategoriesAsync(context);
            await context.SaveChangesAsync();

            await AddStaffAsync(context);
            await context.SaveChangesAsync();

            await AddMoviesAsync(context);
            await context.SaveChangesAsync();

            await transaction.CommitAsync();
        }
        catch
        {
            await transaction.RollbackAsync();
        }
    }

    private static async Task AddMoviesAsync(CinemaNetContext context)
    {
        var movies = new List<Movie>()
        {
            new()
            {
                Id = "99023704-71BE-4A31-BF7A-C0C24569333B",
                Name = "Avatar",
                Description =
                    "To film z 2009 roku, który powraca na ekrany kin 23 września 2022, tylko na ograniczony czas. \"Avatar\" opowiada historię sparaliżowanego byłego komandosa, który dostaje szansę odzyskania zdrowego ciała. Musi jednak wziąć udział w specjalnym programie militarnym o nazwie Avatar. W rolach głównych między innymi Sam Worthington, Sigourney Weaver, Michelle Rodriguez. ***Uwaga*** w filmie AVATAR znajduje się kilka scen z dynamicznymi efektami świetlnymi, które mogą powodować dyskomfort u widzów wrażliwych na światło i wpływać na osoby z epilepsją fotogenną.",
                Duration = 167,
                ReleaseDate = new DateTime(2022, 9, 23),
                State = MovieState.Published,
                CreationDate = DateTime.Now,
                CategoryId = "58D30414-A8B0-4F96-A445-BDD7543A0594",
                Media = new[]
                {
                    new Media
                    {
                        Id = "27FC0CDF-293D-4A3D-9727-661E11C9DEB9",
                        Url = "https://fwcdn.pl/fpo/91/13/299113/8028716.3.jpg"
                    },
                    new Media
                    {
                        Id = "D4501F4A-698A-43EC-8F33-8FD0A65AF6F8", 
                        Url = "https://www.youtube.com/watch?v=_LXWCknsDt0"
                    },
                    new Media
                    {
                        Id = "E47DC997-AEC0-4F69-A968-400854BAEB6F",
                        Url = "https://fwcdn.pl/fpo/91/13/299113/7535712.3.jpg"
                    },
                },
                Staff = new[]
                {
                    new MovieStaff
                    {
                        Role = "Director", 
                        MovieId = "99023704-71BE-4A31-BF7A-C0C24569333B", 
                        StaffId = "293B9D98-5A91-4156-9DCF-B4608FEF64E4"
                    },
                    new MovieStaff
                    {
                        Role = "Actor", 
                        MovieId = "99023704-71BE-4A31-BF7A-C0C24569333B", 
                        StaffId = "B5F26F84-B82F-40F9-8426-3C717296EE90"
                    },
                    new MovieStaff
                    {
                        Role = "Actor", 
                        MovieId = "99023704-71BE-4A31-BF7A-C0C24569333B", 
                        StaffId = "432A49C1-6A33-4FBD-905F-A8C15BE32BA0"
                    }
                }
            },
            new()
            {
                Id = "EEC3CFC3-D1AC-4CA2-9F4D-8E2EA9A4C5A8",
                Name = "Bullet Train",
                Description = "Pięcioro zabójców, znajdujących się w szybkim pociągu jadącym z Tokio do Morioki, odkrywa, że ich zlecenia są ze sobą wzajemnie powiązane. Powstaje pytanie, kto wyjdzie z pociągu żywy i co ich czeka na stacji końcowej.",
                Duration = 126,
                ReleaseDate = new DateTime(2022, 8, 5),
                State = MovieState.Published,
                CreationDate = DateTime.Now,
                CategoryId = "3F59FFAC-D750-4054-82BC-6EBF6B1F4090",
                Media = new []
                {
                    new Media
                    {
                        Id = "FC096B05-D3B9-43BC-8E0D-93EFC5D23F66",
                        Url = "https://fwcdn.pl/fpo/67/01/856701/8021051.3.jpg"
                    }
                },
                Staff = new []
                {
                    new MovieStaff
                    {
                        Role = "Director",
                        MovieId = "EEC3CFC3-D1AC-4CA2-9F4D-8E2EA9A4C5A8",
                        StaffId = "A4429857-BA14-40F5-8EAB-B77CFF4CF89C"
                    },
                    new MovieStaff
                    {
                        Role = "Actor",
                        MovieId = "EEC3CFC3-D1AC-4CA2-9F4D-8E2EA9A4C5A8",
                        StaffId = "4D215C87-A6C7-48EC-B5A7-F514D65957D3"
                    },
                    new MovieStaff
                    {
                        Role = "Actor",
                        MovieId = "EEC3CFC3-D1AC-4CA2-9F4D-8E2EA9A4C5A8",
                        StaffId = "B3B7362E-DE54-4E27-9A31-F320409064A6"
                    }
                }
            }
        };
        
        await context.AddRangeAsync(movies);
        await context.SaveChangesAsync();

        foreach (var movie in movies)
        {
            context.Entry(movie).State = EntityState.Detached;
        }
    }

    private static async Task AddStaffAsync(CinemaNetContext context)
    {
        var staves = new List<Staff>
        {
            new()
            {
                Id = "293B9D98-5A91-4156-9DCF-B4608FEF64E4", 
                FirstName = "James", 
                LastName = "Cameron"
            },
            new()
            {
                Id = "B5F26F84-B82F-40F9-8426-3C717296EE90", 
                FirstName = "CCH", 
                LastName = "Pounder"
            },
            new()
            {
                Id = "432A49C1-6A33-4FBD-905F-A8C15BE32BA0", 
                FirstName = "Sigourney", 
                LastName = "Weaver"
            },
            new()
            {
                Id = "A4429857-BA14-40F5-8EAB-B77CFF4CF89C", 
                FirstName = "David", 
                LastName = "Leitch"
            },
            new()
            {
                Id = "4D215C87-A6C7-48EC-B5A7-F514D65957D3", 
                FirstName = "Brad", 
                LastName = "Pitt"
            },
            new()
            {
                Id = "B3B7362E-DE54-4E27-9A31-F320409064A6", 
                FirstName = "Aaron", 
                LastName = "Tylor-Johnson"
            }
        };

        await context.AddRangeAsync(staves);
        await context.SaveChangesAsync();

        foreach (var staff in staves)
        {
            context.Entry(staff).State = EntityState.Detached;
        }
    }

    private static async Task AddCategoriesAsync(CinemaNetContext context)
    {
        var categories = new List<Category>
        {
            new()
            {
                Id = "FDADE2D0-F830-4E1F-ADE9-146843252402", 
                Name = "Animation"
            },
            new()
            {
                Id = "3F59FFAC-D750-4054-82BC-6EBF6B1F4090", 
                Name = "Action"
            },
            new()
            {
                Id = "A1D6C4F7-A099-4988-9939-9091A60ACA8C", 
                Name = "Biography"
            },
            new() 
            { 
                Id = "FE812BCB-3E36-4D44-BC6C-C35B7C3092AE", 
                Name = "Documentary" 
            },
            new() 
            { 
                Id = "4724E2C7-0F07-4960-8A9A-880CADC9A13A", 
                Name = "Drama" 
            },
            new() { 
                Id = "75C027A8-E27E-4C6F-BE2E-52B9262DB2C7", 
                Name = "Thriller" 
            },
            new()
            {
                Id = "CB7A539E-1DD8-4628-8B1A-CF7221473114", 
                Name = "Family"
            },
            new()
            {
                Id = "58D30414-A8B0-4F96-A445-BDD7543A0594", 
                Name = "Science-Fiction"
            },
            new()
            {
                Id = "48FB2E72-2ADD-4A33-B1D5-D4F825FD4B30", 
                Name = "Horror"
            },
            new()
            {
                Id = "307DAF9E-B8A7-4809-9C3D-6CA1FB41C685", 
                Name = "Comedy"
            },
            new()
            {
                Id = "D2FE0B6B-A416-4434-AAF8-0075C3C9A872", 
                Name = "Romantic Comedy"
            },
            new()
            {
                Id = "C8BE066D-A021-4BDB-93AD-EF76E6168B67", 
                Name = "Adventure"
            }
        };

        await context.AddRangeAsync(categories);
        await context.SaveChangesAsync();

        foreach (var category in categories)
        {
            context.Entry(category).State = EntityState.Detached;
        }
    }
}