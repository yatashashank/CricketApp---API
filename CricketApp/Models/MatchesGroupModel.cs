using System;
using System.Collections.Generic;

namespace CricketApp.Models
{
    public class MatchesGroupModel
    {
        public MatchesGroupModel()
        {

        }

        public MetaModel meta { get; set; }

        public MatchListModel matchList { get; set; }

        public int status { get; set; }

        public string poweredBy { get; set; }
    }
}
