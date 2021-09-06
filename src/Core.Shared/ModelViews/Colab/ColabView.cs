using Core.Shared.ModelViews.Departamento;
using Core.Shared.ModelViews.Grupo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Shared.ModelViews.Colab
{
    public class ColabView
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public string Status { get; set; }
        public string SocialMedia { get; set; }
        public string Descricao { get; set; }
        public ICollection<DepartamentoView> Departamentos { get; set; }
        public ICollection<GrupoView> Grupos { get; set; }
    }
}
