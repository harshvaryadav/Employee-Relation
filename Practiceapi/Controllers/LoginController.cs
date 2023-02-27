using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practiceapi.Models;

namespace Practiceapi.Controllers
{
    public class LoginException:ApplicationException
    {
          public LoginException(string message):base(message)  
          {
                
          }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ACE42023Context _context;

        public LoginController(ACE42023Context context)
        {
            _context = context;
        }

        // GET: api/Login
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usertbl>>> GetUsertbls()
        {
          if (_context.Usertbls == null)
          {
              return NotFound();
          }
            return await _context.Usertbls.ToListAsync();
        }

        // GET: api/Login/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usertbl>> GetUsertbl(string id)
        {
          if (_context.Usertbls == null)
          {
              return NotFound();
          }
            var usertbl = await _context.Usertbls.FindAsync(id);  

            if (usertbl == null)
            {
                return NotFound();
            }
            return usertbl;
        }
        /*public async Task<ActionResult<Usertbl>> CheckUserExist(string id,Usertbl user)  
        {
          Console.WriteLine("Working"); 
          if (_context.Usertbls == null)    
          {
              return NotFound();
          }
            Usertbl usertbl =null;
            foreach(var User in _context.Usertbls)
            {
                    if(User.UserId==user.UserId&&User.Password==user.Password)  
                    {
                       usertbl=User;
                       Console.WriteLine("Working");  
                       break;
                    }
            }
            
            if (usertbl == null)
            {
                return NotFound();  
            }
            return Ok(user);   
        }*/
        /*public IActionResult CheckUserExist(Usertbl user)
        {
               return Ok(_context.Usertbls.Where(x=>x.UserId==user.UserId && x.Password==user.Password).ToList());          
        }*/
        // PUT: api/Login/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsertbl(string id, Usertbl usertbl)   
        {
            if (id != usertbl.UserId)
            {
                return BadRequest();
            }

            _context.Entry(usertbl).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsertblExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Login
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Usertbl>> PostUsertbl(Usertbl usertbl)
        {
          if (_context.Usertbls == null)
          {
              return Problem("Entity set 'ACE42023Context.Usertbls'  is null.");  
          }
          try{
               foreach(var User in _context.Usertbls)
                 {
                   if(User.UserId==usertbl.UserId)
                  {
                     throw new LoginException("UserId Should Unique");  
                  }
                  if(User.UserName==usertbl.UserName)    
                  {
                     throw new LoginException("UserName Already Exist");  
                  }
               }
               _context.Usertbls.Add(usertbl);
               await _context.SaveChangesAsync();
              }
            catch (Exception e)
            {
                return Conflict(e.Message);  
            }
            return CreatedAtAction("GetUsertbl", new { id = usertbl.UserId }, usertbl);  
        }

        // DELETE: api/Login/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsertbl(string id)
        {
            if (_context.Usertbls == null)
            {
                return NotFound();
            }
            var usertbl = await _context.Usertbls.FindAsync(id);
            if (usertbl == null)
            {
                return NotFound();
            }

            _context.Usertbls.Remove(usertbl);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsertblExists(string id)
        {
            return (_context.Usertbls?.Any(e => e.UserId == id)).GetValueOrDefault();
        }
    }
}
