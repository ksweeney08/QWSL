using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QWSL_API.Models;

namespace QWSL_API.Repository
{
    public class GameRepository : IGameRepository, IDisposable
    {
        private QWSLContext context;

        public GameRepository(QWSLContext context)
        {
            this.context = context;

        }

        public IEnumerable<Game> Get()
        {
            return context.Schedules.ToList();
        }

        public Game Get(Guid gameid)
        {
            return context.Schedules.Find(gameid);
        }

        public void Insert(Game game)
        {
            context.Schedules.Add(game);
        }

        public void Delete(Game game)
        {
            context.Schedules.Remove(game);
        }

        public void Delete(Guid gameid)
        {
            Game game = context.Schedules.Find(gameid);
            context.Schedules.Remove(game);
        }

        public void Update(Game game)
        {
            context.Entry(game).State = System.Data.Entity.EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    context.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~GameRepository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}