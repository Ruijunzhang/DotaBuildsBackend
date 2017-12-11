using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//
//    var data = OpenDoTaModel.FromJson(jsonString);
//
namespace DotaBuildsBackend.utilities
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class OpenDoTaModel
    {
        [JsonProperty("barracks_status_dire")]
        public long BarracksStatusDire { get; set; }

        [JsonProperty("barracks_status_radiant")]
        public long BarracksStatusRadiant { get; set; }

        [JsonProperty("chat")]
        public object Chat { get; set; }

        [JsonProperty("cluster")]
        public long Cluster { get; set; }

        [JsonProperty("cosmetics")]
        public object Cosmetics { get; set; }

        [JsonProperty("dire_score")]
        public long DireScore { get; set; }

        [JsonProperty("draft_timings")]
        public object DraftTimings { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("engine")]
        public long Engine { get; set; }

        [JsonProperty("first_blood_time")]
        public long FirstBloodTime { get; set; }

        [JsonProperty("game_mode")]
        public long GameMode { get; set; }

        [JsonProperty("human_players")]
        public long HumanPlayers { get; set; }

        [JsonProperty("leagueid")]
        public long Leagueid { get; set; }

        [JsonProperty("lobby_type")]
        public long LobbyType { get; set; }

        [JsonProperty("match_id")]
        public long MatchId { get; set; }

        [JsonProperty("match_seq_num")]
        public long MatchSeqNum { get; set; }

        [JsonProperty("negative_votes")]
        public long NegativeVotes { get; set; }

        [JsonProperty("objectives")]
        public object Objectives { get; set; }

        [JsonProperty("patch")]
        public long Patch { get; set; }

        [JsonProperty("picks_bans")]
        public object PicksBans { get; set; }

        [JsonProperty("players")]
        public Player[] Players { get; set; }

        [JsonProperty("positive_votes")]
        public long PositiveVotes { get; set; }

        [JsonProperty("radiant_gold_adv")]
        public object RadiantGoldAdv { get; set; }

        [JsonProperty("radiant_score")]
        public long RadiantScore { get; set; }

        [JsonProperty("radiant_win")]
        public bool RadiantWin { get; set; }

        [JsonProperty("radiant_xp_adv")]
        public object RadiantXpAdv { get; set; }

        [JsonProperty("region")]
        public long Region { get; set; }

        [JsonProperty("skill")]
        public object Skill { get; set; }

        [JsonProperty("start_time")]
        public long StartTime { get; set; }

        [JsonProperty("teamfights")]
        public object Teamfights { get; set; }

        [JsonProperty("tower_status_dire")]
        public long TowerStatusDire { get; set; }

        [JsonProperty("tower_status_radiant")]
        public long TowerStatusRadiant { get; set; }

        [JsonProperty("version")]
        public object Version { get; set; }
    }

    public partial class Player
    {
        [JsonProperty("abandons")]
        public long Abandons { get; set; }

        [JsonProperty("ability_upgrades_arr")]
        public long[] AbilityUpgradesArr { get; set; }

        [JsonProperty("ability_uses")]
        public object AbilityUses { get; set; }

        [JsonProperty("account_id")]
        public long? AccountId { get; set; }

        [JsonProperty("actions")]
        public object Actions { get; set; }

        [JsonProperty("additional_units")]
        public object AdditionalUnits { get; set; }

        [JsonProperty("assists")]
        public long Assists { get; set; }

        [JsonProperty("backpack_0")]
        public long Backpack0 { get; set; }

        [JsonProperty("backpack_1")]
        public long Backpack1 { get; set; }

        [JsonProperty("backpack_2")]
        public long Backpack2 { get; set; }

        [JsonProperty("benchmarks")]
        public Benchmarks Benchmarks { get; set; }

        [JsonProperty("buyback_log")]
        public object BuybackLog { get; set; }

        [JsonProperty("camps_stacked")]
        public object CampsStacked { get; set; }

        [JsonProperty("cluster")]
        public long Cluster { get; set; }

        [JsonProperty("cosmetics")]
        public object[] Cosmetics { get; set; }

        [JsonProperty("creeps_stacked")]
        public object CreepsStacked { get; set; }

        [JsonProperty("damage")]
        public object Damage { get; set; }

        [JsonProperty("damage_inflictor")]
        public object DamageInflictor { get; set; }

        [JsonProperty("damage_inflictor_received")]
        public object DamageInflictorReceived { get; set; }

        [JsonProperty("damage_taken")]
        public object DamageTaken { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("denies")]
        public long Denies { get; set; }

        [JsonProperty("dn_t")]
        public object DnT { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("firstblood_claimed")]
        public object FirstbloodClaimed { get; set; }

        [JsonProperty("game_mode")]
        public long GameMode { get; set; }

        [JsonProperty("gold")]
        public long Gold { get; set; }

        [JsonProperty("gold_per_min")]
        public long GoldPerMin { get; set; }

        [JsonProperty("gold_reasons")]
        public object GoldReasons { get; set; }

        [JsonProperty("gold_spent")]
        public long GoldSpent { get; set; }

        [JsonProperty("gold_t")]
        public object GoldT { get; set; }

        [JsonProperty("hero_damage")]
        public long HeroDamage { get; set; }

        [JsonProperty("hero_healing")]
        public long HeroHealing { get; set; }

        [JsonProperty("hero_hits")]
        public object HeroHits { get; set; }

        [JsonProperty("hero_id")]
        public long HeroId { get; set; }

        [JsonProperty("isRadiant")]
        public bool IsRadiant { get; set; }

        [JsonProperty("item_0")]
        public long Item0 { get; set; }

        [JsonProperty("item_1")]
        public long Item1 { get; set; }

        [JsonProperty("item_2")]
        public long Item2 { get; set; }

        [JsonProperty("item_3")]
        public long Item3 { get; set; }

        [JsonProperty("item_4")]
        public long Item4 { get; set; }

        [JsonProperty("item_5")]
        public long Item5 { get; set; }

        [JsonProperty("item_uses")]
        public object ItemUses { get; set; }

        [JsonProperty("kda")]
        public long Kda { get; set; }

        [JsonProperty("kill_streaks")]
        public object KillStreaks { get; set; }

        [JsonProperty("killed")]
        public object Killed { get; set; }

        [JsonProperty("killed_by")]
        public object KilledBy { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("kills_log")]
        public object KillsLog { get; set; }

        [JsonProperty("kills_per_min")]
        public double KillsPerMin { get; set; }

        [JsonProperty("lane_pos")]
        public object LanePos { get; set; }

        [JsonProperty("last_hits")]
        public long LastHits { get; set; }

        [JsonProperty("last_login")]
        public string LastLogin { get; set; }

        [JsonProperty("leaver_status")]
        public long LeaverStatus { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("lh_t")]
        public object LhT { get; set; }

        [JsonProperty("life_state")]
        public object LifeState { get; set; }

        [JsonProperty("lobby_type")]
        public long LobbyType { get; set; }

        [JsonProperty("lose")]
        public long Lose { get; set; }

        [JsonProperty("match_id")]
        public long MatchId { get; set; }

        [JsonProperty("max_hero_hit")]
        public object MaxHeroHit { get; set; }

        [JsonProperty("multi_kills")]
        public object MultiKills { get; set; }

        [JsonProperty("name")]
        public object Name { get; set; }

        [JsonProperty("obs")]
        public object Obs { get; set; }

        [JsonProperty("obs_left_log")]
        public object ObsLeftLog { get; set; }

        [JsonProperty("obs_log")]
        public object ObsLog { get; set; }

        [JsonProperty("obs_placed")]
        public object ObsPlaced { get; set; }

        [JsonProperty("party_id")]
        public object PartyId { get; set; }

        [JsonProperty("party_size")]
        public object PartySize { get; set; }

        [JsonProperty("patch")]
        public long Patch { get; set; }

        [JsonProperty("performance_others")]
        public object PerformanceOthers { get; set; }

        [JsonProperty("permanent_buffs")]
        public object PermanentBuffs { get; set; }

        [JsonProperty("personaname")]
        public string Personaname { get; set; }

        [JsonProperty("pings")]
        public object Pings { get; set; }

        [JsonProperty("player_slot")]
        public long PlayerSlot { get; set; }

        [JsonProperty("pred_vict")]
        public object PredVict { get; set; }

        [JsonProperty("purchase")]
        public object Purchase { get; set; }

        [JsonProperty("purchase_log")]
        public object PurchaseLog { get; set; }

        [JsonProperty("radiant_win")]
        public bool RadiantWin { get; set; }

        [JsonProperty("randomed")]
        public object Randomed { get; set; }

        [JsonProperty("rank_tier")]
        public long? RankTier { get; set; }

        [JsonProperty("region")]
        public long Region { get; set; }

        [JsonProperty("repicked")]
        public object Repicked { get; set; }

        [JsonProperty("roshans_killed")]
        public object RoshansKilled { get; set; }

        [JsonProperty("rune_pickups")]
        public object RunePickups { get; set; }

        [JsonProperty("runes")]
        public object Runes { get; set; }

        [JsonProperty("runes_log")]
        public object RunesLog { get; set; }

        [JsonProperty("sen")]
        public object Sen { get; set; }

        [JsonProperty("sen_left_log")]
        public object SenLeftLog { get; set; }

        [JsonProperty("sen_log")]
        public object SenLog { get; set; }

        [JsonProperty("sen_placed")]
        public object SenPlaced { get; set; }

        [JsonProperty("start_time")]
        public long StartTime { get; set; }

        [JsonProperty("stuns")]
        public object Stuns { get; set; }

        [JsonProperty("teamfight_participation")]
        public object TeamfightParticipation { get; set; }

        [JsonProperty("times")]
        public object Times { get; set; }

        [JsonProperty("total_gold")]
        public long TotalGold { get; set; }

        [JsonProperty("total_xp")]
        public long TotalXp { get; set; }

        [JsonProperty("tower_damage")]
        public long TowerDamage { get; set; }

        [JsonProperty("towers_killed")]
        public object TowersKilled { get; set; }

        [JsonProperty("win")]
        public long Win { get; set; }

        [JsonProperty("xp_per_min")]
        public long XpPerMin { get; set; }

        [JsonProperty("xp_reasons")]
        public object XpReasons { get; set; }

        [JsonProperty("xp_t")]
        public object XpT { get; set; }
    }

    public partial class Benchmarks
    {
        [JsonProperty("gold_per_min")]
        public GoldPerMin GoldPerMin { get; set; }

        [JsonProperty("hero_damage_per_min")]
        public PerMin HeroDamagePerMin { get; set; }

        [JsonProperty("hero_healing_per_min")]
        public PerMin HeroHealingPerMin { get; set; }

        [JsonProperty("kills_per_min")]
        public PerMin KillsPerMin { get; set; }

        [JsonProperty("last_hits_per_min")]
        public PerMin LastHitsPerMin { get; set; }

        [JsonProperty("tower_damage")]
        public GoldPerMin TowerDamage { get; set; }

        [JsonProperty("xp_per_min")]
        public GoldPerMin XpPerMin { get; set; }
    }

    public partial class PerMin
    {
        [JsonProperty("pct")]
        public double Pct { get; set; }

        [JsonProperty("raw")]
        public double Raw { get; set; }
    }

    public partial class GoldPerMin
    {
        [JsonProperty("pct")]
        public double Pct { get; set; }

        [JsonProperty("raw")]
        public long Raw { get; set; }
    }

    public partial class OpenDoTaModel
    {
        public static OpenDoTaModel FromJson(string json) => JsonConvert.DeserializeObject<OpenDoTaModel>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this OpenDoTaModel self) => JsonConvert.SerializeObject(self, Converter.Settings);
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
