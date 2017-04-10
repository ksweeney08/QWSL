namespace QWSL_API
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Models;

    public partial class QWSLContext : DbContext
    {
        public QWSLContext()
            : base("name=QWSLContext")
        {
        }

       
        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
       
        public virtual DbSet<League> Leagues { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Game> Schedules { get; set; }
        public virtual DbSet<TeamPlayer> TeamPlayers { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TeamSeason> TeamSeasons { get; set; }
        public virtual DbSet<SoftballUser> SoftballUsers { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          

            

            modelBuilder.Entity<Content>()
                .Property(e => e.PageName)
                .IsUnicode(false);

            modelBuilder.Entity<Content>()
                .Property(e => e.Content1)
                .IsUnicode(false);

            modelBuilder.Entity<Division>()
                .Property(e => e.DivisionName)
                .IsUnicode(false);

           

            modelBuilder.Entity<League>()
                .Property(e => e.LeagueName)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.CellPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Game>()
                .Property(e => e.Field)
                .IsUnicode(false);

            modelBuilder.Entity<Game>()
                .Property(e => e.Season)
                .IsUnicode(false);

            modelBuilder.Entity<TeamPlayer>()
                .Property(e => e.Season)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.TeamName)
                .IsUnicode(false);

            modelBuilder.Entity<TeamSeason>()
                .Property(e => e.Season)
                .IsUnicode(false);

            modelBuilder.Entity<SoftballUser>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<SoftballUser>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<SoftballUser>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<SoftballUser>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
