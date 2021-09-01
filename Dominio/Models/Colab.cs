using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColabAPI.Models
{
    public class Colab
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Idade { get; set; }
        public string Senha { get; set; }
        public string Status { get; set; }
        public string Departamento { get; set; }
        public string Grupo { get; set; }
        public string SocialMedia { get; set; }
        public string Descricao { get; set; }

    }
}