using DeveloperExercise.Domain.Model;
using MediatR;

namespace DeveloperExercise.Application.Command.SavePerson
{
    public class SavePersonCommand : IRequest<SavePersonCommandResult>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> SocialSkills { get; set; }
        public List<SocialAccount> SocialAccounts { get; set; }
    }

    public class SavePersonCommandResult
    {
        public Guid Id { get; set; }
    }
}
