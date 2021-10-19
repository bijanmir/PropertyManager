using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PropertyManager.DataModel.Model;
using PropertyManager.DataStore.Data;

namespace PropertyManager.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PropController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public PropController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _db.Properties.ToListAsync());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var prop = await _db.Properties.FindAsync(id);
            if (prop == null) return NotFound();

            return Ok(prop);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Property prop)
        {
            await _db.Properties.AddAsync(prop);
            await _db.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetById),
                new { id = prop.PropId },
                prop
            );
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, Property prop)
        {
            if (id != prop.PropId) return BadRequest();
            _db.Entry(prop).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch
            {
                if (await _db.Properties.FindAsync(id) == null) return NotFound();
                throw;
            }

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var prop = await _db.Properties.FindAsync(id);
            if (prop == null) return NotFound();
            await _db.SaveChangesAsync();

            return Ok(prop);
        }
    }
}