using Core.Shared.ModelViews.Colab;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Validator
{
    public class AlteraColabValidator : AbstractValidator<AlteraColab>
    {
        public AlteraColabValidator()
        {
            RuleFor(p => p.Id).NotNull().NotEmpty().GreaterThan(0);
            Include(new NovoColabValidator());
        }
    }
}
