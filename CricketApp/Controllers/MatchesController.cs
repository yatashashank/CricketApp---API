using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using CricketApp.Models;
using CricketApp.Providers;

namespace CricketApp.Controllers
{
    public class MatchesController : ApiController
    {
        [System.Web.Http.AllowAnonymous]
        [System.Web.Http.HttpGet]
        public MatchesGroupModel GetMatches()
        {
            MatchProvider provider = new MatchProvider();

             return  provider.GetMatches();
        }

        public MatchesGroupModel GetMatchesBySeriesID(int seriesID)
        {
            MatchProvider provider = new MatchProvider();

            return provider.GetMatchesBySeries(seriesID);
        }

        public MatchMetaDataModel GetMatchByMatchID(int matchID)
        {
            MatchProvider provider = new MatchProvider();

            return new MatchMetaDataModel();
        }
    }
}
