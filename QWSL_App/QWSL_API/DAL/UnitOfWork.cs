using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QWSL_API.Models;
using QWSL_API.Repository;

namespace QWSL_API.DAL
{
    public class UnitOfWork : IDisposable        
    {
        private QWSLContext context = new QWSLContext();
        private GenericRepository<Game> gameRepository;
        private GenericRepository<Player> playerRepository;
        private GenericRepository<Team> teamRepository;
        private GenericRepository<League> leagueRepository;
        

        public GenericRepository<Game> GameRepository
        {
            get
            {
                if (this.gameRepository == null)
                {
                    this.gameRepository = new GenericRepository<Game>(context);
                }
                return gameRepository;
            }
        }

        public GenericRepository<Player> PlayerRepository
        {
            get
            {
                if (this.playerRepository == null)
                {
                    this.playerRepository = new GenericRepository<Player>(context);
                }
                return playerRepository;
            }
        }

        public GenericRepository<Team> TeamRepository
        {
            get
            {
                if (this.teamRepository == null)
                {
                    this.teamRepository = new GenericRepository<Team>(context);
                }
                return teamRepository;
            }
        }

        public GenericRepository<League> LeagueRepository
        {
            get
            {
                if (this.leagueRepository == null)
                {
                    this.leagueRepository = new GenericRepository<League>(context);
                }
                return leagueRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}