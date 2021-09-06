using Core.Shared.ModelViews.Departamento;
using Core.Shared.ModelViews.Grupo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Shared.ModelViews
{
    public class NovoColab
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Idade { get; set; }
        public string Status { get; set; }
        public string SocialMedia { get; set; }
        public string Descricao { get; set; }
        public ICollection<ReferenciaDepartamento> Departamentos { get; set; }
        public ICollection<ReferenciaGrupo> Grupos { get; set; }
    }
}
