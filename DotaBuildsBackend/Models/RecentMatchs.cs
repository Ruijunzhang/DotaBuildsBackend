using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;

using Newtonsoft.Json;

namespace DotaBuildsBackend.Models.RecentMatch
{
    public partial class RecentMatch
    {
        [JsonProperty("assists")]
        public long Assists { get; set; }

        [JsonProperty("cluster")]
        public long Cluster { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("game_mode")]
        public long GameMode { get; set; }

        [JsonProperty("gold_per_min")]
        public long GoldPerMin { get; set; }

        [JsonProperty("hero_damage")]
        public long HeroDamage { get; set; }

        [JsonProperty("hero_healing")]
        public long HeroHealing { get; set; }

        [JsonProperty("hero_id")]
        public long HeroId { get; set; }

        [JsonProperty("is_roaming")]
        public bool? IsRoaming { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("lane")]
        public long? Lane { get; set; }

        [JsonProperty("lane_role")]
        public long? LaneRole { get; set; }

        [JsonProperty("last_hits")]
        public long LastHits { get; set; }

        [JsonProperty("leaver_status")]
        public long LeaverStatus { get; set; }

        [JsonProperty("lobby_type")]
        public long LobbyType { get; set; }

        [JsonProperty("match_id")]
        public long MatchId { get; set; }

        [JsonProperty("party_size")]
        public long? PartySize { get; set; }

        [JsonProperty("player_slot")]
        public long PlayerSlot { get; set; }

        [JsonProperty("radiant_win")]
        public bool RadiantWin { get; set; }

        [JsonProperty("skill")]
        public object Skill { get; set; }

        [JsonProperty("start_time")]
        public long StartTime { get; set; }

        [JsonProperty("tower_damage")]
        public long TowerDamage { get; set; }

        [JsonProperty("version")]
        public long? Version { get; set; }

        [JsonProperty("xp_per_min")]
        public long XpPerMin { get; set; }
    }

    public partial class RecentMatch
    {
        public static RecentMatch[] FromJson(string json) => JsonConvert.DeserializeObject<RecentMatch[]>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this RecentMatch[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}