using Dominio.Models;
using Repositorio.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColabController : ControllerBase
    {
        private readonly ColabDBContext _context;

        public ColabController(ColabDBContext context)
        {
            _context = context;
        }

        //Método Get
        [HttpGet]
        public List<Colab> GetColabs()
        {
            List<Colab> lista = _context.Colabs.ToList();
            return lista;
        }

        //Método Post
        [HttpPost]
        public string PostColab(Colab colab)
        {
            _context.Colabs.Add(colab);

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
        public string PutColab(Colab colab)
        {
            _context.Colabs.Update(colab);

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
        public string DeleteColab(Colab colab)
        {
            _context.Colabs.Remove(colab);

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
