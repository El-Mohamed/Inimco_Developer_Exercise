namespace DeveloperExercise.Domain.Model
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> SocialSkills { get; set; }
        public List<SocialAccount> SocialAccounts { get; set; }

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
