using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class FilmSiteContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//hangi veri tabanı tanımlandığı yer.
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocalDB;Database=FilmSite;Trusted_Connection=True");
        }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieType> MovieTypes { get; set; }
        public DbSet<MovieAndArtist> MovieAndArtists { get; set; }
        public DbSet<GenreOfMovie> GenreOfMovies { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        //public DbSet<OperationClaim> OperationClaims { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
