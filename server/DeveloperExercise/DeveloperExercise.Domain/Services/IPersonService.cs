using DeveloperExercise.Domain.Model;

namespace DeveloperExercise.Domain.Services
{
    public interface IPersonService
    {
        int GetVowelCount(Person person);
        int GetConsonantCount(Person person);
        string GetReverseName(Person person);
    }
}
