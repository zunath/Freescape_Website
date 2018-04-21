using FluentValidation;
using Freescape.Web.Data.Entities;

namespace Freescape.Web.Models.Validation
{
    public class LootTableItemValidator: AbstractValidator<LootTableItem>
    {
        public LootTableItemValidator()
        {
            RuleFor(x => x.MaxQuantity)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(x => x.Resref)
                .NotNull()
                .NotEmpty()
                .MaximumLength(16);

            RuleFor(x => x.Weight)
                .NotNull()
                .NotEmpty()
                .GreaterThan((byte)0);
        }
    }
}
