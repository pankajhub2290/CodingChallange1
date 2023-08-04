using AutoMapper;
using CouncilVoting.Application.Commands.CreateMeasure;
using CouncilVoting.Application.Commands.SaveVote;
using CouncilVoting.Domain.Entities;
using CouncilVoting.Shared.Models;

namespace CouncilVoting.Api.Mapping
{
    public class MeasureMappingConfig : Profile
    {
        /// <summary>
        /// Mapping configuration
        /// </summary>
        public MeasureMappingConfig()
        {
            CreateMap<CreateMeasureCommand, Measure>();
            CreateMap<CastVoteCommand, Voting>();
        }
    }
}
