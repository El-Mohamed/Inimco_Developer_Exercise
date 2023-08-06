namespace DeveloperExercise.Domain.Services
{
    public interface IPersonService
    {
        int GetVowelCount(string input);
        int GetConsonantCount(string input);
        string GetReverseName(string firstName, string lastName);
    }
}
