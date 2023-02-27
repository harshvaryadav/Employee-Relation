using Microsoft.AspNetCore.Mvc;
using Practiceapi.Models;
namespace Practiceapi.Controllers;

[ApiController]
[Route("api/[controller]")]  
public class TeamController : ControllerBase
{
       private readonly ACE42023Context db=new ACE42023Context();  
       public TeamController(ACE42023Context _db)
       {
              db=_db;
       }
       [HttpGet]
       [Route("GetTeam")]
       public IActionResult GetTeam()
       {
              return Ok(db.Teams.ToList());  
       }
       [HttpGet]
       [Route("GetTeamNames")]
       public IActionResult GetTeamName()
       {
              List<string>Teamname=new List<string>();  
              foreach(var Team in db.Teams)
              {
                      Teamname.Add(Team.TeamName);
              }
              return Ok(Teamname);  
       }
       [HttpGet]
       [Route("GetTeamLead")]
       public IActionResult GetTeamLead(string name)
       {
              return Ok(db.Teams.Where(x=>x.TeamName==name).SingleOrDefault());  
       }
}