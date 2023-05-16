using System.Text.Json.Serialization;

namespace ProiectCofetarie
{
	public class IstoricComenzi
	{
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("email")]
        public string Emailclient { get; set; }
        [JsonPropertyName("data")]
        public string Data { get; set; }
	}
}
