using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Models
{
    public class Colab
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Idade { get; set; }
        public string Senha { get; set; }
        public string Status { get; set; }
        public int DepartamentoColab { get; set; }
        //Relacionamento Dep-Colab
        public Departamento Departamento { get; set; }
        public int GrupoColab { get; set; }
        //Relacionamento Grupo-Colab
        public Grupo Grupo { get; set; }
        public string SocialMedia { get; set; }
        public string Descricao { get; set; }

    }
}