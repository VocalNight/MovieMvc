using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace MovieMvc.Data
{
    public class MovieMvcContext : IdentityDbContext
    {
        public MovieMvcContext (DbContextOptions<MovieMvcContext> options)
            : base(options)
        {
        }

        public DbSet<MovieMvc.Models.Movie> Movie { get; set; } = default!;
    }
}
