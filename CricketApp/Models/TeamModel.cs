using System;
namespace CricketApp.Models
{
    public class TeamModel
    {
        public TeamModel()
        {
            
        }

        public int id { get; set; }

        public string name { get; set; }

        public string shortName { get; set; }

        public bool isBatting { get; set; }

        public string logoUrl { get; set; }

        public string teamColour { get; set; }

        public string score { get; set; }
    }
}
