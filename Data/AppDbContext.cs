using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext()
        {
                
        }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=eTicket;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.Movie_Id,
                am.Actor_Id
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.movie).WithMany(am =>am.Actor_Movies)
                .HasForeignKey(m =>m.Movie_Id);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.actor).WithMany(am => am.Actor_Movies)
                .HasForeignKey(m => m.Actor_Id);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Cinema> Cinemies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Actor_Movie> Actor_Movies { get; set; }


    }
}
