using DeveloperExercise.Application.Command.SavePerson;
using FluentValidation;

public class SaveUserCommandValidator : AbstractValidator<SavePersonCommand>
{
    public SaveUserCommandValidator()
    {
        RuleFor(command => command.NewPerson.FirstName).MinimumLength(3);
        RuleFor(command => command.NewPerson.LastName).NotEmpty();
    }
}
