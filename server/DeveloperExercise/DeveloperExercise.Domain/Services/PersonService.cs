namespace DeveloperExercise.Domain.Services
{
    public class PersonService : IPersonService
    {
        public int GetConsonantCount(string input)
        {
            return input.Count();
        }

        public string GetReverseName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}"; // TODO
        }

        public int GetVowelCount(string input)
        {
            var formatted = input.Trim();
            return formatted.Count();
        }
    }
}
