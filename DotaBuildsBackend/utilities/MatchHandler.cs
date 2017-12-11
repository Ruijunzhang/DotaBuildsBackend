using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotaBuildsBackend.Models.RecentMatch;

namespace DotaBuildsBackend.utilities
{
    public class MatchHandler
    {

        DataFactory dataFactory = new DataFactory();

        public bool IsWon(RecentMatch Match)
        {
            return Match.RadiantWin && (Match.PlayerSlot < dataFactory.GetRadiantIndex());
        }
    }
}