using Core.Domain;
using Core.Shared.ModelViews;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Validator
{
    public class NovoColabValidator : AbstractValidator<NovoColab>
    {
        public NovoColabValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty();
            RuleFor(x => x.Idade).NotNull().NotEmpty().GreaterThanOrEqualTo(16);
            RuleFor(x => x.Status).NotNull().NotEmpty().Must(IsMorf).WithMessage("Status ativo ou inativo");
        }

        private bool IsMorf(string status)
        {
            return status == "ativo" || status == "inativo";
        }
    }
}
