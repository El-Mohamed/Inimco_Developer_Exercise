using DeveloperExercise.Application.Command.SavePerson;
using FluentValidation;

public class SaveUserCommandValidator : AbstractValidator<SavePersonCommand>
{
    public SaveUserCommandValidator()
    {
        RuleFor(command => command.NewPerson.FirstName).NotNull();
        RuleFor(command => command.NewPerson.LastName).NotNull();
    }
}
