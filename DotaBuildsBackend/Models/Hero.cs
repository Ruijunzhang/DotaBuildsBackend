using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotaBuildsBackend.Models
{
    public class Hero
    {
        public string name;
        public int id;
        public string localizedName;

        public Hero(int id, string name, string localizedName)
        {
            this.id = id;
            this.name = name;
            this.localizedName = localizedName;
        }
    }
}