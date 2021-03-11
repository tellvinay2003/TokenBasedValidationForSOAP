using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OdlAuthService.Models;

namespace OdlAuthService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthContext _context;

        public AuthController(AuthContext context)
        {
            _context = context;
        }

        // GET: api/Auth
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AspnetUsers>>> GetAspnetUsers()
        {
            return await _context.AspnetUsers.ToListAsync();
        }

        // GET: api/Auth/5
        // [HttpGet("{id}")]
        [HttpGet()]
        public async Task<ActionResult<AspnetUsers>> GetAspnetUsersById([FromBody]Guid id)
        {
            var aspnetUsers = await _context.AspnetUsers.FindAsync(id);

            if (aspnetUsers == null)
            {
                return NotFound();
            }

            return aspnetUsers;
        }

        // PUT: api/Auth/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        // [HttpPut("{id}")]
        [HttpPut()]
        public async Task<IActionResult> PutAspnetUsers(Guid id, AspnetUsers aspnetUsers)
        {
            if (id != aspnetUsers.UserId)
            {
                return BadRequest();
            }

            _context.Entry(aspnetUsers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AspnetUsersExists(id))
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

        // POST: api/Auth
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<AspnetUsers>> PostAspnetUsers([FromBody]AspnetUsers aspnetUsers)
        {
            var aspNetApp = new AspnetApplications
            {
                ApplicationId = Guid.NewGuid(),
                ApplicationName = "newApplication" + DateTime.Now.ToString(),
                LoweredApplicationName = "new application" + DateTime.Now.ToString(),
                Description = "testApplication"
            };

            aspnetUsers.Application = aspNetApp;
            _context.AspnetApplications.Add(aspNetApp);

            _context.AspnetUsers.Add(aspnetUsers);

            await _context.SaveChangesAsync();

            // return CreatedAtAction("GetAspnetUsers", new { id = aspnetUsers.UserId }, aspnetUsers);
            return CreatedAtAction("GetAspnetUsers", new { id = aspnetUsers.UserId }, aspnetUsers.UserName);
        }

        // DELETE: api/Auth/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AspnetUsers>> DeleteAspnetUsers(Guid id)
        {
            var aspnetUsers = await _context.AspnetUsers.FindAsync(id);
            if (aspnetUsers == null)
            {
                return NotFound();
            }

            _context.AspnetUsers.Remove(aspnetUsers);
            await _context.SaveChangesAsync();

            return aspnetUsers;
        }

        private bool AspnetUsersExists(Guid id)
        {
            return _context.AspnetUsers.Any(e => e.UserId == id);
        }
    }
}
