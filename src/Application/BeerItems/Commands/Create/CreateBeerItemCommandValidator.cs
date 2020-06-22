using FluentValidation;

namespace BeerTracker.Application.BeerItems.Commands.Create
{
    public class CreateBeerItemCommandValidator : AbstractValidator<CreateBeerItemCommand>
    {
        public CreateBeerItemCommandValidator()
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