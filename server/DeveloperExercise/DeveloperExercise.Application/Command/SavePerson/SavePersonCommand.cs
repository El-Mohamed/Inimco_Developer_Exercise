using DeveloperExercise.Domain.Model;
using MediatR;

namespace DeveloperExercise.Application.Command.SavePerson
{
    public class SavePersonCommand : IRequest<SavePersonCommandResult>
    {
        public Person NewPerson { get; set; }
    }

    public class SavePersonCommandResult
    {
        public Guid Id { get; set; }
    }
}
