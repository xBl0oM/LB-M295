using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Floorballer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FloorballController : Controller
    {
        private readonly FloorballContext _db;

        public FloorballController(FloorballContext context)
        {
            _db = context;
        }

        [HttpPost ("PostPlayer")]
        public IActionResult PostPlayer(Player player)
        {
            try
            {
                _db.Players.Add(player);
                _db.SaveChanges();
                return CreatedAtAction("GetPlayer", new { id = player.Id }, player);
            }
            catch 
            {
                return BadRequest("Ooops, that didn't work...");
            }


        }
        [HttpPost ("PostTeam")]
        public IActionResult PostTeam(Team team)
        {
            try 
            { 
            _db.Teams.Add(team);
            _db.SaveChanges();
            return CreatedAtAction("GetTeam", new { id = team.Id }, team);
            }
            catch
            {
                return BadRequest("Ooops, that didn't work...");
            }

        }
        [HttpGet ("GetPlayer")]
        public IActionResult GetPlayer(int id)
        {

            try
            {
                Player playerFromDb = _db.Players.SingleOrDefault(e => e.Id == id);

                if (playerFromDb == null)
                    {
                         return NotFound(); 
                    }
                    return Ok(playerFromDb);
            }
            catch
            {
                return BadRequest("Ooops, that didn't work...");
            }


        }
        [HttpGet ("GetTeam")]

        public IActionResult GetTeam(int id)
        {

            try
            {
                Team teamFromDb = _db.Teams.SingleOrDefault(e => e.Id == id);

            if (teamFromDb == null)
            {
                return NotFound();
            }
            return Ok(teamFromDb);

            }
            catch
            {
                return BadRequest("Ooops, that didn't work...");
            }

        }

        [HttpGet]
        [Route("GetAllPlayers")]
        public IActionResult GetPlayers()
        {

            try
            {
                var allPlayers = _db.Players.ToList();
            if (allPlayers.Count == 0)
            {
                return Ok("No Players in Database");
            }
            return Ok(allPlayers);

            }
            catch
            {
                return BadRequest("Ooops, that didn't work...");
            }

        }
        [HttpGet ("GetAllTeams")]
        public IActionResult GetTeams()
        {
            try
            {
                var allTeams = _db.Teams.ToList();
            if (allTeams.Count == 0)
            {
                return Ok("No Teams in Database");
            }
            return Ok(allTeams);

            }
            catch
            {
                return BadRequest("Ooops, that didn't work...");
            }

        }

        [HttpPut ("PutPlayer")]
        public IActionResult PutPlayer(Player player)
        {
            try
            {
                Player playerFromDb = _db.Players.SingleOrDefault(e => e.Id == player.Id);
            if (playerFromDb == null)
            {
                return NotFound();
            }

            playerFromDb.Player_first_name = player.Player_first_name;
            playerFromDb.Player_last_name = player.Player_last_name;
            playerFromDb.Player_shirt_number = player.Player_shirt_number;
            playerFromDb.Player_age = player.Player_age;
            _db.SaveChanges();
            return Ok("Updated Player succesfully.");

            }
            catch
            {
                return BadRequest("Ooops, that didn't work...");
            }


        }
        [HttpPut("PutTeam")]
        public IActionResult PutTeam(Team team)
        {
            try
            {
                Team teamFromDb = _db.Teams.SingleOrDefault(e => e.Id == team.Id);
                if (teamFromDb == null)
                {
                  return NotFound();
                }

                teamFromDb.Team_name = team.Team_name;
                teamFromDb.Team_slogan = team.Team_slogan;
                teamFromDb.Team_native_country = team.Team_native_country;
                teamFromDb.Team_founded_in = team.Team_founded_in;
                _db.SaveChanges();
                return Ok("Updated Team succesfully.");

            }
            catch
            {
                return BadRequest("Ooops, that didn't work...");
            }

        }
        [HttpDelete ("DeletePlayer")]
        public IActionResult DeletePlayer(int id)
        {
            try
            {
                Player playerFromDb = _db.Players.SingleOrDefault(e => e.Id == id);

                if (playerFromDb == null)
                {
                    return NotFound();
                }
             _db.Remove(playerFromDb);
             _db.SaveChanges();
             return Ok("Deleted Player");

            }
            catch
            {
                return BadRequest("Ooops, that didn't work...");
            }

        }
        [HttpDelete ("DeleteTeam")]
        public IActionResult DeleteTeam(int id) 
        {
            try
            {
                Team teamFromDb = _db.Teams.SingleOrDefault(e => e.Id == id);

            if (teamFromDb == null)
            {
                return NotFound();
            }
            _db.Remove(teamFromDb);
            _db.SaveChanges();
            return Ok("Deleted Team");

            }
            catch
            {
                return BadRequest("Ooops, that didn't work...");
            }

        }

    }
}
