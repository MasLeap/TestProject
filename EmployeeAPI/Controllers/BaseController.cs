using EmployeeAPI.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IBaseEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public BaseController(TRepository repository)
        {
            this.repository = repository;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var result = await repository.Get(id);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity result)
        {
            if (id.CompareTo(result.Id) != 0)
            {
                return BadRequest();
            }
            await repository.Update(result);
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity result)
        {
            await repository.Add(result);
            return CreatedAtAction("Get", new { id = result.Id }, result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var result = await repository.Delete(id);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }

    }
}
