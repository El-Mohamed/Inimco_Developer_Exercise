using DeveloperExercise.Domain.Model;
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
            //Create a new person using the CreateNew method
           var newPerson = Person.Create(
               request.FirstName,
               request.LastName,
               request.SocialSkills,
               request.SocialAccounts
           );

            await _personRepository.SavePerson(newPerson, cancellationToken);

            return new SavePersonCommandResult() { Id = Guid.NewGuid() };
        }
    }
}
