using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DotaBuildsBackend.Models;

namespace DotaBuildsBackend.utilities
{
    public class DataFactory
    {
        HttpClient client = new HttpClient();
        DotaRemoteRepoManager dotaRemoteRepoManager = new DotaRemoteRepoManager();
        Dictionary<long, Hero> heroMap;

        public async Task<Hero> GetHerosById(long heroId)
        {
            if(heroMap == null)
            {
                heroMap = await BuildHerosMap();
            }
            return heroMap[heroId];          
        }

        public int GetRadiantIndex()
        {
            return 5;
        }

        private async Task<Dictionary<long, Hero>> BuildHerosMap()
        {
            Heros[] heros = await GetHeros();

            Dictionary<long, Hero> heroMap = new Dictionary<long, Hero>();

            foreach (Heros hero in heros)
            {
                Hero dotaBuildHero = new Hero((int)hero.Id, hero.Name,hero.LocalizedName);
                heroMap.Add(hero.Id, dotaBuildHero);
            }
            return heroMap;
        }

        private async Task<Heros[]> GetHeros()
        {
            HttpResponseMessage response = await client.GetAsync(dotaRemoteRepoManager.GetHerosApiRemoteUrl());
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            return Heros.FromJson(responseBody);
        }
    }
}