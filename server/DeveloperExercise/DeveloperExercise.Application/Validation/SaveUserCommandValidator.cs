using DeveloperExercise.Application.Command.SavePerson;
using FluentValidation;

public class SaveUserCommandValidator : AbstractValidator<SavePersonCommand>
{
    public SaveUserCommandValidator()
    {
        RuleFor(command => command.FirstName).NotEmpty();
        RuleFor(command => command.LastName).NotEmpty();
        RuleFor(command => command.SocialSkills).NotEmpty(); 
        RuleFor(command => command.SocialAccounts).NotEmpty(); 
    }
}
