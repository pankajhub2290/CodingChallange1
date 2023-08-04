namespace CouncilVoting.Shared.Models
{
    public class VotingResultResponseModel
    {
        public MeasureResponseModel Measure { get; set; }

        public List<UserResponseModel> Users { get; set; }

        public bool IsPassed { get; set; }
        public int TotalNoOfVotes { get; set; }
    }
    public class UserResponseModel
    {
        public int UserId { get; set; }
        public OptionResponseModel Options { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
