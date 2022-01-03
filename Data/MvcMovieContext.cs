using Microsoft.EntityFrameworkCore;
using Practice1.Models;

namespace Practice1.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}