using Newtonsoft.Json;
using System.Collections.Generic;

namespace Etude.Models
{
    public class RecipePuppyResponse
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("version")]
        public decimal Version { get; set; }

        [JsonProperty("results")]
        public IEnumerable<Recipe> Recipies { get; set; }
    }

    public class Recipe
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("href")]
        public string Reference { get; set; }

        [JsonProperty("ingredients")]
        public string Ingredients { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
    }
}
