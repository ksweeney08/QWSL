using QWSL_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QWSL_API.Repository;
using QWSL_API.DAL;
using System.Data.Entity.Infrastructure;

namespace QWSL_API.Controllers
{
    [RoutePrefix("api/games")]
    public class GamesController : ApiController
    {

        private UnitOfWork unitOfWork = new UnitOfWork();

        //private IGameRepository gameRepository;

        //public GamesController()
        //{
        //    //this.gameRepository = new GameRepository(new QWSLContext());
        //}

        //public GamesController(IGameRepository gameRepository)
        //{
        //    //this.gameRepository = gameRepository;
        //}
        [Route(Name="games")]
        public IEnumerable<Game> Get()
        {


            var games = from g in unitOfWork.GameRepository.Get()
                        select g;
            return games;
            
            
            //using (var db = new QWSLContext())
            //{
            //    IQueryable<Game> gamesQuery = from game in db.Schedules
            //                                  select game;

            //    foreach (var game in gamesQuery)
            //    {
            //        games.Add(game);
            //    }

            //    return games;

            //};

        }

        [Route("{gameid:Guid}")]
        public IHttpActionResult Get(Guid gameid)
        {

            Game game = unitOfWork.GameRepository.GetByID(gameid);
            if (game == null)
            {
                return NotFound();
            }
            return Ok(game);


            //using (var db = new QWSLContext())
            //{
            //    var game = db.Schedules
            //        .Where(g => g.GameID.ToString().ToUpper() == gameid.ToString().ToUpper())
            //        .FirstOrDefault();

            //    if (game == null)
            //    {
            //        return NotFound();
            //    }
            //    return Ok(game);

            //};


        }

        [Route]        
        public IHttpActionResult Post([FromBody] Game game)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }



            unitOfWork.GameRepository.Insert(game);

            unitOfWork.Save();

            return CreatedAtRoute("games", new { gameid = game.GameID }, game);
        }

        [Route("{gameid:Guid}")]
        public IHttpActionResult Put(Guid gameid, Game game)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Game repoGame = unitOfWork.GameRepository.GetByID(gameid);

            repoGame.Postponed = game.Postponed;
            unitOfWork.GameRepository.Update(repoGame);
            unitOfWork.Save();            

            return StatusCode(HttpStatusCode.NoContent);
        }

        protected override void Dispose(bool disposing)
        {
            unitOfWork.Dispose();
            base.Dispose(disposing);
        }










    }
}
