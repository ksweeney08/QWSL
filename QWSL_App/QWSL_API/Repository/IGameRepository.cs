using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QWSL_API.Models;

namespace QWSL_API.Repository
{
    public interface IGameRepository : IDisposable
    {
        IEnumerable<Game> Get();
        Game Get(Guid gameid);
        void Insert(Game game);
        void Delete(Game game);
        void Delete(Guid gameid);
        void Update(Game game);
        void Save();
    }
}