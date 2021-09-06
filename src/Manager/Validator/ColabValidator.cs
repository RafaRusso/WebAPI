using Core.Domain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Validator
{
    public class ColabValidator : AbstractValidator<Colab>
    {
        public ColabValidator()
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
