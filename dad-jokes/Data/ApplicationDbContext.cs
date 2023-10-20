using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
//  using Npgsql.EntityFrameworkCore.PostgreSQL;

// TODO: This file may need updating to work with PostgreSQL

namespace dad_jokes.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<dad_jokes.Models.Joke> Joke { get; set; } = default!;
    }
}