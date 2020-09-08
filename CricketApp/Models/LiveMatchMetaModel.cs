using System;
namespace CricketApp.Models
{
    public class LiveMatchMetaModel
    {
        public LiveMatchMetaModel()
        {
            
        }

        public bool hasFullScorecard { get; set; }

        public bool hasCompleted { get; set; }

        public bool hasCommentary { get; set; }

        public bool hasGraph { get; set; }

        public bool hasPlayerProfile { get; set; }

        public bool hasWagonWheel { get; set; }

        public int currentBattingTeam { get; set; }

        public SeriesModel series { get; set; }

        public string requiredRunRate { get; set; }

        public string currentRunRate { get; set; }

        public string matchName { get; set; }

        public string matchType { get; set; }

        public string venueName { get; set; }

        public int currentInningsId { get; set; }

        public int currentDay { get; set; }
    }
}
