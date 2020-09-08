using System;
namespace CricketApp.Models
{
    public class MetaModel
    {
        public MetaModel()
        {

        }

        public int upcomingMatchCount { get; set; }

        public int inProgressMatchCount { get; set; }

        public int completedMatchCount { get; set; }
    }
}
