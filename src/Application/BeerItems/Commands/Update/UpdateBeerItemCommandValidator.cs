using FluentValidation;

namespace BeerTracker.Application.BeerItems.Commands.Update
{
    public class UpdateBeerItemCommandValidator : AbstractValidator<UpdateBeerItemCommand>
    {
        public UpdateBeerItemCommandValidator()
        {
            RuleFor(v => v.Title)
                .MaximumLength(300)
                .NotEmpty();

            RuleFor(v => v.Abv)
                .NotEmpty();

            RuleFor(v => v.Style)
                .NotEmpty();
        }
    }
}
