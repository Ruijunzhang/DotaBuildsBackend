using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotaBuildsBackend.Models;

namespace DotaBuildsBackend.utilities
{
    public class Match
    {
        public Hero hero { get; set; }
        public bool isWon { get; set; }
        public long kill { get; set; }
        public long death { get; set; }
        public long gpm { get; set; }
        public long assist { get; set; }
        public long matchId { get; set; }
    }
}