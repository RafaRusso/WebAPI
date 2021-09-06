using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain;
using Manager.Interfaces;
using Manager.Implementation;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ColabAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GruposController : ControllerBase
    {
        private readonly IGrupoManager grupoManager;
        public GruposController(IGrupoManager grupoManager)
        {
            this.grupoManager = grupoManager;
        }
        // GET: api/<GrupoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await grupoManager.GetGruposAsync());
        }

        // GET api/<GrupoController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await grupoManager.GetGrupoAsync(id));
        }

        // POST api/<GrupoController>
        [HttpPost]
        public async Task<ActionResult<Grupo>> Post(Grupo grupo)
        {
            var grupoInserido = await grupoManager.InsertGrupoAsync(grupo);
            return CreatedAtAction(nameof(Get), new { id = grupo.Id }, grupo);
        }

        // PUT api/<GrupoController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Grupo grupo)
        {
            var grupoAtualizado = await grupoManager.UpdateGrupoAsync(grupo);
            if (grupoAtualizado == null)
            {
                return NotFound();
            }
            return Ok(grupoAtualizado);
        }

        // DELETE api/<GrupoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await grupoManager.DeleteGrupoAsync(id);
            return NoContent();
        }
    }
}
