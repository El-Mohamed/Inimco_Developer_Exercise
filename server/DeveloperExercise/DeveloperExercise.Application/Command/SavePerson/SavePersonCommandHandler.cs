using DeveloperExercise.Domain.Repositories;
using MediatR;

namespace DeveloperExercise.Application.Command.SavePerson
{
    public class SavePersonCommandHandler : IRequestHandler<SavePersonCommand, SavePersonCommandResult>
    {
        private readonly IPersonRepository _personRepository;

        public SavePersonCommandHandler(IPersonRepository personRepository)
        {
            _personRepository = personRepository ?? throw new ArgumentNullException(nameof(personRepository));
        }

        public async Task<SavePersonCommandResult> Handle(SavePersonCommand request, CancellationToken cancellationToken)
        {
            await _personRepository.SavePerson(request.NewPerson, cancellationToken);
            return new SavePersonCommandResult() { Id = Guid.NewGuid() };
        }
    }
}
