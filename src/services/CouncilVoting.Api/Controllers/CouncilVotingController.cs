using AutoMapper;
using CouncilVoting.Application.Commands.CreateMeasure;
using CouncilVoting.Application.Commands.SaveVote;
using CouncilVoting.Application.Queries.GetVotingResult;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CouncilVoting.Api.Controllers
{
    /// <summary>
    ///     Council voting api controller
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class CouncilVotingController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public CouncilVotingController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        /// <summary>
        ///     Create a new measure with options
        /// </summary>
        /// <param name="command"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("CreateMeasure")]
        public async Task<IActionResult> Post(CreateMeasureCommand command, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(command, cancellationToken);
            return Ok(response);
        }
        /// <summary>
        ///     Save user's vote on measure
        /// </summary>
        /// <param name="command"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPost("CastVote")]
        public async Task<IActionResult> Post(CastVoteCommand command, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(command, cancellationToken);
            return Ok(response);
        }
        /// <summary>
        ///     Get voting results of a measure
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet("{measureId:int}")]
        public async Task<IActionResult> Get(int measureId, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetVotingResultQuery { MeasureId = measureId }, cancellationToken);
            return Ok(response);
        }
    }
}
