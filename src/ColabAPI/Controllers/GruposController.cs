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
        /// <summary>
        /// Retorna todos os grupos cadastrados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await grupoManager.GetGruposAsync());
        }

        /// <summary>
        /// Retorna um grupo via Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await grupoManager.GetGrupoAsync(id));
        }

        /// <summary>
        /// Inclui um grupo no banco de dados.
        /// </summary>
        /// <param name="grupo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post(Grupo grupo)
        {
            var grupoInserido = await grupoManager.InsertGrupoAsync(grupo);
            return CreatedAtAction(nameof(Get), new { id = grupo.Id }, grupo);
        }

        /// <summary>
        /// Altera um banco de dados cadastrado.
        /// </summary>
        /// <param name="grupo"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Exclui um grupo do banco de dados.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await grupoManager.DeleteGrupoAsync(id);
            return NoContent();
        }
    }
}
