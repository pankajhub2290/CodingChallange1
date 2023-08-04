using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouncilVoting.Shared.Models
{
    public class MeasureResponseModel
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public int MinimumNoOfVotesRequired { get; set; }
        public List<OptionResponseModel> OptionResponse { get; set; }
    }
}
