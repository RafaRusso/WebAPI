using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Domain
{
    /// <summary>
    /// Objeto utilizado para novo colaborador.
    /// </summary>
    public class Colab
    {
        /// <summary>
        /// ID do colaborador.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nome do cliente.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Email do Colaborador
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Idade do colaborador
        /// </summary>
        public int Idade { get; set; }
        /// <summary>
        /// Senha:
        /// </summary>
        public string Senha { get; set; }
        /// <summary>
        /// Status:
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// ID do departamento que o colaborador participa:
        /// </summary>
        public int DepartamentoId { get; set; }
        //Relacionamento Dep-Colab
        //public Departamento Departamento { get; set; }
        /// <summary>
        /// ID do grupo que o colaborador participa:
        /// </summary>
        public int GrupoId { get; set; }
        //Relacionamento Grupo-Colab
        //public Grupo Grupo { get; set; }
        /// <summary>
        /// Social Media:
        /// </summary>
        public string SocialMedia { get; set; }
        /// <summary>
        /// Descrição:
        /// </summary>
        public string Descricao { get; set; }

    }
}