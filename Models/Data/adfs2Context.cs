

using adfs2.Models;
using Microsoft.EntityFrameworkCore;

namespace adfs2.Data
{
    public class adfs2Context : DbContext
    {
        public adfs2Context (DbContextOptions<adfs2Context> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }

    }
}