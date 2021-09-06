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
        // GET: api/<DepartamentoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await departamentoManager.GetDepartamentosAsync());
        }

        // GET api/<DepartamentoController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await departamentoManager.GetDepartamentoAsync(id));
        }

        // POST api/<DepartamentoController>
        [HttpPost]
        public async Task<ActionResult<Departamento>> Post(Departamento departamento)
        {
            var departamentoInserido = await departamentoManager.InsertDepartamentoAsync(departamento);
            return CreatedAtAction(nameof(Get), new { id = departamento.Id }, departamento);
        }

        // PUT api/<DepartamentoController>/5
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

        // DELETE api/<DepartamentoController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await departamentoManager.DeleteDepartamentoAsync(id);
            return NoContent();
        }
    }
}
