using System;
namespace CricketApp.Models
{
    public class LiveMatchDetailModel
    {
        public LiveMatchDetailModel()
        {

        }

        public TeamModel teamBatting { get; set; }

        public TeamModel teamBowling { get; set; }


    }
}
