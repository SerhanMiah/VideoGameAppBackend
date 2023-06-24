using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoGameAppBackend.Data;
using VideoGameAppBackend.Models;

namespace VideoGameAppBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly GameDbContext _dbContext;

        public GameController(GameDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        // GET: api/game
        [HttpGet]
        public ActionResult<IEnumerable<Game>> GetGamesWithImages()
        {
            // var requestUrl = HttpContext.Request.Path.Value;

            var gamesWithImages = _dbContext.Games
                .Include(g => g.GameImages)
                .ToList();

            return gamesWithImages;
        }

        [HttpGet("{id}")]
        public ActionResult<Game> GetGame(int id)
        {
            var game = _dbContext.Games.FirstOrDefault(g => g.Id == id);
            
            if (game == null)
            {
                return NotFound();
            }

            return game;
        }
        
    }
}