using DeveloperExercise.Domain.Model;

namespace DeveloperExercise.Domain.Services
{
    public class PersonService : IPersonService
    {
        public int GetConsonantCount(Person person)
        {
            var fullName = person.FirstName + " " + person.LastName;
            var formatted = fullName.Trim().ToLower();
            return formatted.Count(c => !("aeiou".Contains(c)));

        }

        public string GetReverseName(Person person)
        {
            var fullName = person.FirstName + " " + person.LastName;
            char[] charArray = fullName.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public int GetVowelCount(Person person)
        {
            var fullName = person.FirstName + " " + person.LastName;
            var formatted = fullName.Trim().ToLower();
            return formatted.Count(c => "aeiou".Contains(c));
        }
    }
}
