using DeveloperExercise.Application.Command.SavePerson;
using DeveloperExercise.Application.Queries.GetPersonCalculations;
using DeveloperExercise.Domain.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperExercise.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetPerson")]
        public async Task<IActionResult> GetPerson()
        {
            var result = await _mediator.Send(new GetPersonCalculationsQuery());
            return new OkObjectResult(result);
        }

        [HttpPost(Name = "SavePerson")]
        public async Task<SavePersonCommandResult> SavePerson([FromBody] Person person)
        {
            var result = await _mediator.Send(new SavePersonCommand() { NewPerson = person });
            return result;
        }
    }
}
