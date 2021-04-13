﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
   public class MatchupModel
    {
        public List<MatchupEntryModel> entries { get; set; } = new List<MatchupEntryModel>();

        public TeamModel winner { get; set; }

        public int MatchupRound { get; set; }

    }
}
