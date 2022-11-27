using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
 

public class Match
    {
        public long Id { get; set; }
        public string? Description { get; set; }

        public DateTime MatchDate { get; set; }

        public DateTime MatchTime { get; set; }
        public string? TeamA { get; set; }
        public string? TeamB { get; set; }

    }

    }
