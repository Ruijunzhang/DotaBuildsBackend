using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using DotaBuildsBackend.utilities;
using Newtonsoft.Json;
using DotaBuildsBackend.Models;
using DotaBuildsBackend.Models.RecentMatch;

namespace DotaBuildsBackend.Controllers
{
    [RoutePrefix("api/dotabuilds")]
    public class DotaBuildsBackendController : ApiController
    {

        HttpClient client = new HttpClient();
        DotaRemoteRepoManager dotaRemoteRepoManager = new DotaRemoteRepoManager();
        DataFactory dataFactory = new DataFactory();
        MatchHandler matchHandler = new MatchHandler();

        [HttpGet, Route("GetRecentMatchById")]
        public async Task<object> GetRecentMatch(string userId)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(dotaRemoteRepoManager.GetUserRecentMatchsById(userId));
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                RecentMatch[] recentMatchs =  RecentMatch.FromJson(responseBody);

                List<Match> returnMatchs = new List<Match>();

                foreach (RecentMatch match in recentMatchs)
                {
                    Match playerMatch = new Match();

                    playerMatch.assist = match.Assists;
                    playerMatch.death = match.Deaths;
                    playerMatch.gpm = match.GoldPerMin;
                    playerMatch.hero = await dataFactory.GetHerosById(match.HeroId);
                    playerMatch.isWon = matchHandler.IsWon(match);
                    playerMatch.kill = match.Kills;
                    playerMatch.matchId = match.MatchId;

                    returnMatchs.Add(playerMatch);
                }

                var json = JsonConvert.SerializeObject(returnMatchs, Formatting.Indented,
                    new JsonSerializerSettings { ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver() });


                return Ok(json);
            }
            catch (HttpRequestException e)
            {
                return Ok("no match found");
            }

        }


        [HttpGet, Route("GetMatchDetails")]
        public async Task<object> GetMatchDetails(string matchId)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(dotaRemoteRepoManager.GetMatchApiRemoteUrl(matchId));
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                OpenDoTaModel recentMatchs = OpenDoTaModel.FromJson(responseBody);

                var json = JsonConvert.SerializeObject(recentMatchs, Formatting.Indented,
                    new JsonSerializerSettings { ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver() });

                return Ok(json);
            }
            catch (HttpRequestException e)
            {
                return Ok("no match details found");
            }      
        
        }


        [HttpGet, Route("IsNewMatch")]
        public async Task<object> IsNewMatch(string userId)
        {
            return Ok("23");
        }

        [HttpGet, Route("getAllMatch")]
        public async Task<object> getAllMatch(string userId)
        {
            return Ok("3");
        }

    }
}