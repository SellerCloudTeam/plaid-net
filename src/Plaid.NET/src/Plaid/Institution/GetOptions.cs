using Newtonsoft.Json;

namespace Acklann.Plaid.Institution
{
    public class GetOptions
    {
        [JsonProperty("products")]
        public string[] Products { get; set; }

        [JsonProperty("include_optional_metadata")]
        public bool IncludeOptionalMetadata { get; set; }

        [JsonProperty("country_codes")]
        public string[] CountryCodes { get; set; }
    }
}