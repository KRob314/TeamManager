using Duende.IdentityServer.EntityFramework.Options;
using Humanizer.Localisation;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TeamManager.Models;

namespace TeamManager.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
            : base(options, operationalStoreOptions)
        {

        }
        //public ApplicationDbContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }


            base.OnModelCreating(modelBuilder);


        }

        public DbSet<Season> Seasons { get; set; } = default!;
        public DbSet<Team> Teams { get; set; } = default!;
        public DbSet<Player> Players { get; set; } = default!;
        public DbSet<Ballpark> Ballparks { get; set; } = default!;
        public DbSet<Game> Games { get; set; } = default!;
        public DbSet<GameHittingStats> GameHittingStats  { get; set; } = default!;
        public DbSet<GameFieldingStats> GameFieldingStats { get; set; } = default!;
        public DbSet<GamePitchingStats> GamePitchingStats  { get; set; } = default!;

        public DbSet<SeasonFieldingStats> SeasonFieldingStats { get; set; } = default!;
        public DbSet<SeasonHittingStats> SeasonHittingStats { get; set; } = default!;
        public DbSet<SeasonPitchingStats> SeasonPitchingStats { get; set; } = default!;
        
    }
}