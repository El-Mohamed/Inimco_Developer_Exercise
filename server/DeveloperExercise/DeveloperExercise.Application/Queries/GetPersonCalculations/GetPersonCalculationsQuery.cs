using MediatR;

namespace DeveloperExercise.Application.Queries.GetPersonCalculations
{
    public class GetPersonCalculationsQuery : IRequest<GetPersonCalculationsQueryResult>
    {
        public Guid Guid { get; set; }
    }

    public class GetPersonCalculationsQueryResult
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NumberOfVowels { get; set; }
        public int NumberOfConsonants { get; set; }
        public string FullName { get; set; }
        public string ReverseFullName { get; set; }
    }
}
