using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain;
using Manager.Interfaces;
using Manager.Implementation;
using Core.Shared.ModelViews;

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
        /// <param name="novoGrupo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post(NovoGrupo novoGrupo)
        {
            var grupoInserido = await grupoManager.InsertGrupoAsync(novoGrupo);
            return CreatedAtAction(nameof(Get), new { id = grupoInserido.Id }, grupoInserido);
        }

        /// <summary>
        /// Altera um banco de dados cadastrado.
        /// </summary>
        /// <param name="alteraGrupo"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(AlteraGrupo alteraGrupo)
        {
            var grupoAtualizado = await grupoManager.UpdateGrupoAsync(alteraGrupo);
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
