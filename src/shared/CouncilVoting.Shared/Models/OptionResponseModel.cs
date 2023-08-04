using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouncilVoting.Shared.Models
{
    public class OptionResponseModel
    {
        public int Id { get; set; }
        public int MeasureId { get; set; }
        public string Option { get; set; }
    }
}
