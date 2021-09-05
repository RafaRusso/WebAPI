using Dominio.Models;
using Microsoft.AspNetCore.Mvc;
using Repositorio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColabAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : Controller
    {
        private readonly ColabDBContext _context;

        public DepartamentoController(ColabDBContext context)
        {
            _context = context;
        }

        //Método Get
        [HttpGet]
        public List<Departamento> GetDepartamentos()
        {
            List<Departamento> lista = _context.Departamentos.ToList();
            return lista;
        }

        //Método Post
        [HttpPost]
        public string PostDepartamento(Departamento departamento)
        {
            _context.Departamentos.Add(departamento);

            int valor = _context.SaveChanges();

            if (valor > 0)
            {
                return "Cadastrado com sucesso!";
            }
            else
            {
                return "Error!";
            }
        }

        //Método Put
        [HttpPut]
        public string PutDepartamento(Departamento departamento)
        {
            _context.Departamentos.Update(departamento);

            int valor = _context.SaveChanges();

            if (valor > 0)
            {
                return "Alterado com sucesso!";
            }
            else
            {
                return "Error!";
            }
        }

        //Método Delete
        [HttpDelete]
        public string DeleteDepartamento(Departamento departamento)
        {
            _context.Departamentos.Remove(departamento);

            int valor = _context.SaveChanges();

            if (valor > 0)
            {
                return "Excluido com sucesso!";
            }
            else
            {
                return "Error!";
            }
        }
    }
}

