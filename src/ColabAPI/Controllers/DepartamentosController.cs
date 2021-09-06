using Core.Domain;
using Manager.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ColabAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentosController : ControllerBase
    {
        private readonly IDepartamentoManager departamentoManager;
        public DepartamentosController(IDepartamentoManager departamentoManager)
        {
            this.departamentoManager = departamentoManager;
        }
        /// <summary>
        /// Retorna todos os departamentos cadastrados
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await departamentoManager.GetDepartamentosAsync());
        }

        /// <summary>
        /// retorna um departamendo via ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await departamentoManager.GetDepartamentoAsync(id));
        }

        /// <summary>
        /// inclui um departamento
        /// </summary>
        /// <param name="departamento"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post(Departamento departamento)
        {
            var departamentoInserido = await departamentoManager.InsertDepartamentoAsync(departamento);
            return CreatedAtAction(nameof(Get), new { id = departamento.Id }, departamento);
        }

        /// <summary>
        /// altera um departamento
        /// </summary>
        /// <param name="departamento"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Departamento departamento)
        {
            var departamentoAtualizado = await departamentoManager.UpdateDepartamentoAsync(departamento);
            if (departamentoAtualizado == null)
            {
                return NotFound();
            }
            return Ok(departamentoAtualizado);
        }

        /// <summary>
        /// Exclui um departamento do banco de dados
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await departamentoManager.DeleteDepartamentoAsync(id);
            return NoContent();
        }
    }
}
