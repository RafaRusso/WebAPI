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
    public class GrupoController : Controller
    {
        private readonly ColabDBContext _context;

        public GrupoController(ColabDBContext context)
        {
            _context = context;
        }

        //Método Get
        [HttpGet]
        public List<Grupo> GetGrupos()
        {
            List<Grupo> lista = _context.Grupos.ToList();
            return lista;
        }

        //Método Post
        [HttpPost]
        public string PostGrupo(Grupo grupo)
        {
            _context.Grupos.Add(grupo);

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
        public string PutGrupo(Grupo grupo)
        {
            _context.Grupos.Update(grupo);

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
        public string DeleteGrupo(Grupo grupo)
        {
            _context.Grupos.Remove(grupo);

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
