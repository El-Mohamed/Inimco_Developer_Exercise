using DeveloperExercise.Domain.Entity;

namespace DeveloperExercise.Domain.Model
{
    public class Person : IEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> SocialSkills { get; set; }
        public List<SocialAccount> SocialAccounts { get; set; }
    }
}
