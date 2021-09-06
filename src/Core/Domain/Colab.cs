using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Domain
{
    public class Colab
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Idade { get; set; }
        public string Senha { get; set; }
        public string Status { get; set; }
        public int DepartamentoId { get; set; }
        //Relacionamento Dep-Colab
        public Departamento Departamento { get; set; }
        public int GrupoId { get; set; }
        //Relacionamento Grupo-Colab
        public Grupo Grupo { get; set; }
        public string SocialMedia { get; set; }
        public string Descricao { get; set; }

    }
}