using System;
using System.Collections.Generic;
using CricketApp.Models;
using Newtonsoft.Json;
using RestSharp;

namespace CricketApp.Providers
{
    public class MatchProvider
    {
        public MatchProvider()
        {
        }

        public MatchesGroupModel GetMatches()
        {
            MatchesGroupModel matches = new MatchesGroupModel();
            
                var client = new RestClient("https://dev132-cricket-live-scores-v1.p.rapidapi.com/matches.php?completedlimit=5&inprogresslimit=5&upcomingLimit=5");
                var request = new RestRequest(Method.GET);
                request.AddHeader("x-rapidapi-host", "dev132-cricket-live-scores-v1.p.rapidapi.com");
                request.AddHeader("x-rapidapi-key", "53e75fc238mshc7c10146833a6e2p15182ajsn9fe99221f9bf");
                IRestResponse response = client.Execute(request);

                matches = JsonConvert.DeserializeObject<MatchesGroupModel>(response.Content);

            return matches;
        }

        public MatchesGroupModel GetMatchesBySeries(int seriesID)
        {
            MatchesGroupModel matches = new MatchesGroupModel();

            var client = new RestClient(string.Format("https://dev132-cricket-live-scores-v1.p.rapidapi.com/matchseries.php?seriesid={0}", seriesID));
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "dev132-cricket-live-scores-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "53e75fc238mshc7c10146833a6e2p15182ajsn9fe99221f9bf");
            IRestResponse response = client.Execute(request);

            matches = JsonConvert.DeserializeObject<MatchesGroupModel>(response.Content);

            return matches;
        }

        public MatchMetaDataModel GetMatchByMatchID(int matchID)
        {
            MatchMetaDataModel match = new MatchMetaDataModel();

            var client = new RestClient(string.Format("https://dev132-cricket-live-scores-v1.p.rapidapi.com/match.php?seriesid=2141&matchid={0}", matchID));
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "dev132-cricket-live-scores-v1.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "53e75fc238mshc7c10146833a6e2p15182ajsn9fe99221f9bf");
            IRestResponse response = client.Execute(request);

            match = JsonConvert.DeserializeObject<MatchMetaDataModel>(response.Content);

            return match;
        }
    }
}
