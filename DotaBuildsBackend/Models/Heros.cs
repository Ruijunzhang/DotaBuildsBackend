using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using DotaBuildsBackend.Models;
//
//    var data = Heros.FromJson(jsonString);
//
namespace DotaBuildsBackend.Models
{
    using Newtonsoft.Json;

    public partial class Heros
    {
        [JsonProperty("attack_type")]
        public string AttackType { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("legs")]
        public long Legs { get; set; }

        [JsonProperty("localized_name")]
        public string LocalizedName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("primary_attr")]
        public string PrimaryAttr { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }
    }

    public partial class Heros
    {
        public static Heros[] FromJson(string json) => JsonConvert.DeserializeObject<Heros[]>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Heros[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
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
