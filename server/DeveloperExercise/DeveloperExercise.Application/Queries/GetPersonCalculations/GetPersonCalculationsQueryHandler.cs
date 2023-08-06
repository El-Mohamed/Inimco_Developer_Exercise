using DeveloperExercise.Domain.Repositories;
using DeveloperExercise.Domain.Services;
using MediatR;

namespace DeveloperExercise.Application.Queries.GetPersonCalculations
{
    internal class GetPersonCalculationsQueryHandler : IRequestHandler<GetPersonCalculationsQuery, GetPersonCalculationsQueryResult>
    {
        private readonly IPersonRepository _personRepository;
        private readonly IPersonService _personService;

        public GetPersonCalculationsQueryHandler(IPersonRepository personRepository, IPersonService personService)
        {
            _personRepository = personRepository;
            _personService = personService;
        }

        public async Task<GetPersonCalculationsQueryResult> Handle(GetPersonCalculationsQuery query, CancellationToken cancellationToken)
        {
            var person = await _personRepository.GetPerson(cancellationToken);

            var result = new GetPersonCalculationsQueryResult()
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                FullName = person.FirstName + person.LastName,
                NumberOfConsonants = _personService.GetConsonantCount(person.FirstName),
                ReverseFullName = "",
                NumberOfVowels = 2
            };

            return result;
        }
    }
}
