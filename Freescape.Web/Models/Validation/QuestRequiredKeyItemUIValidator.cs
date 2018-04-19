using FluentValidation;
using Freescape.Web.Models.UI.QuestEditor;

namespace Freescape.Web.Models.Validation
{
    public class QuestRequiredKeyItemUIValidator: AbstractValidator<QuestRequiredKeyItemUI>
    {
        public QuestRequiredKeyItemUIValidator()
        {
            RuleFor(x => x.RequiredKeyItemID)
                .NotNull()
                .NotEmpty()
                .GreaterThanOrEqualTo(-1);
        }
    }
}
