using DeveloperExercise.Domain.Model;

namespace DeveloperExercise.Domain.Repositories
{
    public interface IPersonRepository
    {
        Task SavePerson(Person person, CancellationToken cancellationToken);
        Task<Person> GetPerson(CancellationToken cancellationToken);
    }
}
