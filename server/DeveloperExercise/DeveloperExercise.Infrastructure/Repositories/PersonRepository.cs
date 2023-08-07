using DeveloperExercise.Domain.Configurations;
using DeveloperExercise.Domain.Model;
using DeveloperExercise.Domain.Repositories;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace DeveloperExercise.Infrastructure.Repositories
{
    internal class PersonRepository : BaseFileRepository, IPersonRepository
    {
        public PersonRepository(IOptions<FileBasedDatabaseOptions> fileBasedDatabaseOptions) : base(fileBasedDatabaseOptions)
        {
        }

        public Task<Person> GetPerson(CancellationToken cancellationToken)
        {
            string jsonString = File.ReadAllText(_filePath);
            Person person = JsonSerializer.Deserialize<Person>(jsonString);
            return Task.FromResult(person);
        }

        public Task SavePerson(Person person, CancellationToken cancellationToken)
        {
            string jsonString = JsonSerializer.Serialize(person);
            File.WriteAllText(_filePath, jsonString);
            return Task.CompletedTask;
        }
    }
}
