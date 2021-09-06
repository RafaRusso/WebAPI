using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core.Domain;
using Manager.Interfaces;
using Microsoft.AspNetCore.Http;

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

        /// <summary>
        /// Retorna todos os colaboradores cadastrados
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(Colab),StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails),StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            return Ok(await colabManager.GetColabsAsync());
        }

        /// <summary>
        /// Retorna um colaborador consultado via id
        /// </summary>
        /// <param name="id">Id do colaborador</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Colab), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await colabManager.GetColabAsync(id));
        }

        /// <summary>
        /// Inclui um colaborador no banco de dados
        /// </summary>
        /// <param name="colab"></param>
        /// <returns></returns>

        [HttpPost]
        [ProducesResponseType(typeof(Colab),StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post(Colab colab)
        {
            var colabInserido = await colabManager.InsertColabAsync(colab);
            return CreatedAtAction(nameof(Get), new { id = colab.Id }, colab);
        }

        /// <summary>
        /// Altera um colaborador
        /// </summary>
        /// <param name="colab"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(typeof(Colab), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Put(Colab colab)
        {
            var colabAtualizado = await colabManager.UpdateColabAsync(colab);
            if (colabAtualizado == null)
            {
                return NotFound();
            }
            return Ok(colabAtualizado);
        }

        /// <summary>
        /// Exclui um colaborador
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Colab), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(int id)
        {
            await colabManager.DeleteColabAsync(id);
            return NoContent();
        }
    }
}
