using System;
namespace CricketApp.Models
{
    public class MatchMetaDataModel
    {
        public MatchMetaDataModel()
        {

        }

        public MatchModel match { get; set; }

        public string status { get; set; }

        public string poweredBy { get; set; }

    }
}
