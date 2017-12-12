using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotaBuildsBackend.utilities
{
    public class DotaRemoteRepoManager
    {

        public String GetMatchApiRemoteUrl(string matchId)
        {
            return "https://api.opendota.com/api/matches/" + matchId;
        }

        public String GetHerosApiRemoteUrl()
        {
            return "https://api.opendota.com/api/heroes";
        }

        public String GetUserRecentMatchsById(string userId)
        {
            return "https://api.opendota.com/api/players/" + userId + "/recentMatches";
        }

    }
}