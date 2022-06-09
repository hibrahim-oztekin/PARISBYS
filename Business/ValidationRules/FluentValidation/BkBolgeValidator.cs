
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BkBolgeValidator : AbstractValidator<BkBolges>
    {
        public BkBolgeValidator()
        {
            RuleFor(b => b.Ad).NotEmpty();
        }
    }
}
