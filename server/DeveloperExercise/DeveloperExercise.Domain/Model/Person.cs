using DeveloperExercise.Domain.Entity;

namespace DeveloperExercise.Domain.Model
{
    public class Person: IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> SocialSkills { get; set; }
        public List<SocialAccount> SocialAccounts { get; set; }
        public Guid Id { get; set; }

        /// <summary>
        /// Creates a new instance of the <see cref="Person"/> class with the provided information.
        /// </summary>
        /// <param name="firstName">The first name of the person.</param>
        /// <param name="lastName">The last name of the person.</param>
        /// <param name="socialSkills">The list of social skills of the person.</param>
        /// <param name="socialAccounts">The list of social accounts of the person.</param>
        /// <returns>A new <see cref="Person"/> instance.</returns>
        /// <exception cref="ArgumentException">Thrown when the provided first or last name is null, empty, or whitespace,
        /// or when no social skills are provided.</exception>
        public static Person Create(string firstName, string lastName, List<string> socialSkills, List<SocialAccount> socialAccounts)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("First name cannot be empty or whitespace.");
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("Last name cannot be empty or whitespace.");
            }

            if (socialSkills == null || !socialSkills.Any())
            {
                throw new ArgumentException("At least one social skill is required.");
            }

            return new Person
            {
                Id = Guid.NewGuid(),
                FirstName = firstName,
                LastName = lastName,
                SocialSkills = socialSkills.ToList(),
                SocialAccounts = socialAccounts.ToList()
            };
        }

        public void ChangeName(string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
            {
                throw new ArgumentException("New name cannot be empty or whitespace.");
            }

            if (FirstName == newName)
            {
                throw new InvalidOperationException("New name must be different from the current name.");
            }

            FirstName = newName;
        }
    }
}
