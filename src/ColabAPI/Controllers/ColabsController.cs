using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Domain;
using Data.Context;
using Manager.Interfaces;

namespace ColabAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColabsController : ControllerBase
    {
        private readonly IColabManager colabManager;
        public ColabsController(IColabManager colabManager)
        {
            this.colabManager = colabManager;
        }

        // GET: api/Colabs
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await colabManager.GetColabsAsync());
        }

        // GET: api/Colabs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await colabManager.GetColabAsync(id));
        }

        // POST: api/Colabs

        [HttpPost]
        public async Task<ActionResult<Colab>> Post(Colab colab)
        {
            var colabInserido = await colabManager.InsertColabAsync(colab);
            return CreatedAtAction(nameof(Get), new { id = colab.Id }, colab);
        }

        // PUT: api/Colabs/5
        [HttpPut]
        public async Task<IActionResult> Put(Colab colab)
        {
            var colabAtualizado = await colabManager.UpdateColabAsync(colab);
            if (colabAtualizado == null)
            {
                return NotFound();
            }
            return Ok(colabAtualizado);
        }

        // DELETE: api/Colabs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await colabManager.DeleteColabAsync(id);
            return NoContent();
        }
    }
}
