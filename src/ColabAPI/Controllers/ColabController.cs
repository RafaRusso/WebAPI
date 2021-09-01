using ColabAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColabAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColabController : ControllerBase
    {
        public static List<Colab> lista = new List<Colab>();

        //Método Get
        [HttpGet]
        public List<Colab> GetGrupo()
        {
            return lista;
        }

        //Método Post
        [HttpPost]
        public string PostColab(Colab colab)
        {
            lista.Add(colab);
            return "Cadastro!";
        }

        //Método Put
        [HttpPut]
        public string PutColab(Colab colab)
        {
            Colab colabAux = lista.Where(x => x.Id == colab.Id).FirstOrDefault();
            colabAux.Name = colab.Name;
            colabAux.Email = colab.Email;
            return "Colaborador atualizado!";
        }

        //Método Delete
        [HttpDelete]
        public string DeleteColab(Colab colab)
        {
            Colab colabAux = lista.Where(x => x.Id == colab.Id).FirstOrDefault();
            lista.Remove(colabAux);
            return "Colaborador excluido!";
        }
    }
}
