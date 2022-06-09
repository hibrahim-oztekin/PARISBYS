using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class DernekValidator : AbstractValidator<Derneks>
    {
        public DernekValidator()
        {
            RuleFor(d => d.Ad).NotEmpty().WithMessage("{PropertyName} alanı asla boş olmamalıdır.");
            RuleFor(d => d.Ad).Length(0, 28);
            RuleFor(d => d.BkBolgesId).NotNull();
            RuleFor(d => d.CrcmUyelikFormDurumId).NotNull();
            RuleFor(d => d.KurulusKanunId).NotNull();
            RuleFor(d => d.SehirId).NotNull();
            RuleFor(d => d.BaslangicTarih).NotNull();

        }
    }
}
