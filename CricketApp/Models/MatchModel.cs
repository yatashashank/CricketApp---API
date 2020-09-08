using System;
namespace CricketApp.Models
{
    public class MatchModel
    {
        public MatchModel()
        {
        }

        public int id { get; set; }

        public int matchTypeId {get; set;}

        public SeriesModel series { get; set; }

        public string name { get; set; }

        public string status { get; set; }

        public VenueModel venue { get; set; }

        public TeamModel homeTeam { get; set; }

        public TeamModel awayTeam { get; set; }

        public string currentMatchState { get; set; }

        public bool isMultiDay { get; set; }

        public string matchSummaryText { get; set; }

        public ScoreModel scores { get; set; }

        public bool isMatchDrawn { get; set; }

        public bool isMatchAbandoned { get; set; }

        public int winningTeamId { get; set; }

        public DateTime startDateTime { get; set; }

        public DateTime endDateTime { get; set; }

        public string localStartDate { get; set; }

        public string localStartTime { get; set; }

        public bool isWomensMatch { get; set; }

        public string cmsMatchType { get; set; }

        public string cmsMatchAssociatedType { get; set; }

        public DateTime cmsMatchVenueStartDateTime { get; set; }

        public DateTime cmsMatchVenueEndDateTime { get; set; }


    }
}
